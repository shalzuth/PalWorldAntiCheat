using Microsoft.Win32.SafeHandles;
using SDK.Script.EngineSDK;
using SDK.Script.PalSDK;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using UnrealSharp;

namespace PalWorldAntiCheat
{
    public unsafe static class Program
    {
        public static bool AntiCheat(UEObject obj, string funcName, nint Parms)
        {
            if (funcName == "K2_OnMovementModeChanged" && obj.IsA(out PalPlayerCharacter playerChar) && playerChar.Controller.IsA(out PalPlayerController controller))
            {
                if (((*(long*)Parms) & 0x400) == 0x400 && !controller.IsRidingFlyPal())
                {
                    System.Console.WriteLine("PLAYER TRYING TO FLY - KICKING!");

                    var fstralloc = Marshal.AllocHGlobal(0x100); // todo, better alloc ctor
                    UnrealEngine.FString(fstralloc, Encoding.Unicode.GetBytes("fly hack kick"));
                    var ftextalloc = Marshal.AllocHGlobal(0x100);
                    UnrealEngine.FText(ftextalloc, fstralloc);
                    controller.ClientWasKicked(ftextalloc);
                    Marshal.FreeHGlobal(fstralloc);
                    Marshal.FreeHGlobal(ftextalloc);
                    playerChar.K2_DestroyActor();
                    // need to remove them from the server still
                    return true;
                }
            }
            return false;
        }
        public static Int32 Main()
        {
            var proc = Process.GetCurrentProcess();
            if (Process.GetCurrentProcess().ProcessName == typeof(Program).Namespace) NativeNetSharp.NativeNetSharp.InjectCore("PalServer-Win64-Test-Cmd", System.Reflection.Assembly.GetEntryAssembly().Location);
            else
            {
                try
                {
                    NativeNetSharp.NativeNetSharp.AllocConsole();
                    var standardOutput = new StreamWriter(new FileStream(new SafeFileHandle(NativeNetSharp.NativeNetSharp.GetStdHandle(-11), true), FileAccess.Write), Encoding.ASCII) { AutoFlush = true };
                    System.Console.SetOut(standardOutput);
                    System.Console.WriteLine("C# DLL loaded");
                    var ue = new UnrealEngine(new Memory(Process.GetCurrentProcess()));
                    System.Console.WriteLine("Updating addresses");
                    ue.UpdateAddresses();
                    UEObject.ProcessEventContinueHook = AntiCheat;
                    var World = new World(UnrealEngine.Memory.ReadProcessMemory<nint>(UnrealEngine.GWorldPtr)); if (!World.IsA<World>()) return 1;
                    var OwningGameInstance = World.OwningGameInstance.As<PalGameInstance>(); if (!OwningGameInstance.IsA<PalGameInstance>()) return 2;
                    System.Console.WriteLine("Hooking Game Instance");
                    World.HookProcessEvent();
                    var players = World.GameState.PlayerArray;
                    for(var i = 0; i < players.Num; i++)
                    {
                        var player = players[i];
                        player.As<PalPlayerState>().PawnPrivate.HookProcessEvent();
                    }
                    // todo hook players joining
                    System.Console.WriteLine("Hooked Game Instance");
                    System.Console.ReadLine();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("err" + " : " + e.Message);
                }
            }
            return 0;
        }
    }
}