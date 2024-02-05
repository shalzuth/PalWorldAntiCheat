using System.Diagnostics;
using System.Runtime.InteropServices;

namespace NativeNetSharp;

public static unsafe class NativeStackWalk
{
    public static List<StackFrame> CaptureStackBackTrace()
    {
        var res = NtQueryInformationThread(GetCurrentThread(), 0, out ThreadBasicInformation tbi, Marshal.SizeOf<ThreadBasicInformation>(), out _);
        var ctxData = (CONTEXT64*)NativeMemory.AllocZeroed(2048 * 2 * 2);
        RtlCaptureContext(ctxData);
        var rsp = (nint)ctxData->Rsp;
        NativeMemory.Free(ctxData);
        var handle = Process.GetCurrentProcess().Handle;
        SymSetOptions(SymOptions.SYMOPT_UNDNAME | SymOptions.SYMOPT_DEFERRED_LOADS);
        SymInitialize(handle, null, 1);
        var frames = new List<StackFrame> { };
        var numFrames = 20;
        while (rsp + 8 < tbi.TebBaseAddress->NtTib.StackBase + 1 && frames.Count < numFrames)
        {
            var address = *(nint*)rsp;
            rsp += 4;
            if ((address & 0xFFF000000000) != 0x7FF000000000) continue;
            var moduleBase = SymGetModuleBase64(handle, address);
            var frame = new StackFrame { address = address };// - moduleBase };
            // c# func is == 0?
            if (moduleBase != 0)
            {
                var buf = NativeMemory.Alloc(256 * sizeof(char));
                if (GetModuleFileNameEx(handle, moduleBase, buf, 256)) frame.module = Marshal.PtrToStringAnsi((IntPtr)buf);
                NativeMemory.Free(buf);
            }
            frames.Add(frame);
        }
        SymCleanup(handle);
        return frames;
    }
    public class StackFrame
    {
        public nint address;
        public string module = "";
    }
    // https://learn.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-context
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    struct CONTEXT64
    {
        public ulong P1Home;
        public ulong P2Home;
        public ulong P3Home;
        public ulong P4Home;
        public ulong P5Home;
        public ulong P6Home;

        public uint ContextFlags;
        public uint MxCsr;

        public ushort SegCs;
        public ushort SegDs;
        public ushort SegEs;
        public ushort SegFs;
        public ushort SegGs;
        public ushort SegSs;

        public uint EFlags;

        public ulong Dr0;
        public ulong Dr1;
        public ulong Dr2;
        public ulong Dr3;
        public ulong Dr6;
        public ulong Dr7;

        public ulong Rax;
        public ulong Rcx;
        public ulong Rdx;
        public ulong Rbx;
        public ulong Rsp;
        public ulong Rbp;
        public ulong Rsi;
        public ulong Rdi;
        public ulong R8;
        public ulong R9;
        public ulong R10;
        public ulong R11;
        public ulong R12;
        public ulong R13;
        public ulong R14;
        public ulong R15;
        public ulong Rip;
        // don't care about the rest...
    }
    struct CLIENT_ID
    {
        public nint UniqueProcess;
        public nint UniqueThread;
    }
    struct ThreadBasicInformation
    {
        public uint ExitStatus;
        public ThreadEnvironmentBlock* TebBaseAddress;
        public CLIENT_ID ClientId;
        public uint* AffinityMask;
        public uint Priority;
        public uint BasePriority;
    }

    [StructLayout(LayoutKind.Explicit)]// https://github.com/powercode/PSExt/blob/405a3b1835001e0e9ba035a8336f86a204bb8d54/src/Extension/DebugStructs_x64.cs#L367
    public struct ThreadEnvironmentBlock
    {
        [FieldOffset(0x000)] public NT_TIB NtTib;
        [FieldOffset(0x058)] public UInt64 ThreadLocalStoragePointer;
        [FieldOffset(0x1480)] public UInt64 TlsSlots;
        [FieldOffset(0x1780)] public UInt64 TlsExpansionSlots;
    }
    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct NT_TIB
    {
        [FieldOffset(0x000)] public nint ExceptionList;
        [FieldOffset(0x008)] public nint StackBase;
        [FieldOffset(0x010)] public nint StackLimit;
        [FieldOffset(0x018)] public nint SubSystemTib;
        [FieldOffset(0x020)] public nint FiberData;
        [FieldOffset(0x020)] public uint Version;
        [FieldOffset(0x028)] public nint ArbitraryUserPointer;
        [FieldOffset(0x030)] public nint Self;
    }

    [Flags]
    enum SymOptions : uint
    {
        SYMOPT_CASE_INSENSITIVE = 0x00000001,
        SYMOPT_UNDNAME = 0x00000002,
        SYMOPT_DEFERRED_LOADS = 0x00000004,
        SYMOPT_NO_CPP = 0x00000008,
        SYMOPT_LOAD_LINES = 0x00000010,
        SYMOPT_OMAP_FIND_NEAREST = 0x00000020,
        SYMOPT_LOAD_ANYTHING = 0x00000040,
        SYMOPT_IGNORE_CVREC = 0x00000080,
        SYMOPT_NO_UNQUALIFIED_LOADS = 0x00000100,
        SYMOPT_FAIL_CRITICAL_ERRORS = 0x00000200,
        SYMOPT_EXACT_SYMBOLS = 0x00000400,
        SYMOPT_ALLOW_ABSOLUTE_SYMBOLS = 0x00000800,
        SYMOPT_IGNORE_NT_SYMPATH = 0x00001000,
        SYMOPT_INCLUDE_32BIT_MODULES = 0x00002000,
        SYMOPT_PUBLICS_ONLY = 0x00004000,
        SYMOPT_NO_PUBLICS = 0x00008000,
        SYMOPT_AUTO_PUBLICS = 0x00010000,
        SYMOPT_NO_IMAGE_SEARCH = 0x00020000,
        SYMOPT_SECURE = 0x00040000,
        SYMOPT_NO_PROMPTS = 0x00080000,
        SYMOPT_OVERWRITE = 0x00100000,
        SYMOPT_IGNORE_IMAGEDIR = 0x00200000,
        SYMOPT_FLAT_DIRECTORY = 0x00400000,
        SYMOPT_DEBUG = 0x80000000,
    }

    // https://geoffchappell.com/studies/windows/km/ntoskrnl/api/ps/psquery/class.htm
    [DllImport("ntdll")] static extern UInt64 NtQueryInformationThread(nint hProcess, int id, out ThreadBasicInformation tbi, int cb, out int pSize);
    [DllImport("kernel32")] static extern void RtlCaptureContext(void* ContextRecord);
    [DllImport("kernel32")] static extern nint GetCurrentThread();
    [DllImport("dbghelp")] static extern bool SymInitialize(nint hProcess, string UserSearchPath, int fInvadeProcess);
    [DllImport("dbghelp")] static extern bool SymSetOptions(SymOptions SymOptions);
    [DllImport("dbghelp")] static extern nint SymGetModuleBase64(nint hProcess, nint Address);
    [DllImport("dbghelp")] static extern bool SymCleanup(nint hProcess);
    [DllImport("psapi")] static extern bool GetModuleFileNameEx(nint hProcess, nint hModule, [Out] void* lpFilename, uint nSize);
}