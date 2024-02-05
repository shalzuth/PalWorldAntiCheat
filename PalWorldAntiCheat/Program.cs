using Microsoft.Win32.SafeHandles;
using SDK.Script.AIModuleSDK;
using SDK.Script.EngineSDK;
using SDK.Script.InputCoreSDK;
using SDK.Script.PalSDK;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;
using UnrealSharp;

namespace PalWorldAntiCheat
{
    public unsafe static class Program
    {
        public static void KickPlayer(PalPlayerCharacter playerChar, PalPlayerController controller)
        {
            return;
            var fstralloc = Marshal.AllocHGlobal(0x100); // todo, better alloc ctor
            UnrealEngine.FString(fstralloc, Encoding.Unicode.GetBytes("fly hack kick"));
            var ftextalloc = Marshal.AllocHGlobal(0x100);
            UnrealEngine.FText(ftextalloc, fstralloc);
            playerChar.K2_DestroyActor();
            controller.ClientWasKicked(ftextalloc);
            Marshal.FreeHGlobal(fstralloc);
            Marshal.FreeHGlobal(ftextalloc);
            controller.K2_DestroyActor();
            // need to remove them from the server still
        }
        public static bool AntiCheat(UEObject obj, string funcName, nint Parms)
        {
            var namesToSkip = new List<string> { "ReceiveTick", "ClientMoveResponsePacked", "ServerMovePacked", "Regene_CustomEvent", "ServerUpdateCamera", "SetCameraRotatorToPlayerCharacter_ToServer" };
            if (!namesToSkip.Contains(funcName))
                System.Console.WriteLine(obj.ClassName + " : " +  funcName);
            if (obj.IsA(out PalPlayerCharacter playerChar) && playerChar.Controller.IsA(out PalPlayerController controller))
            {
                if (funcName == "K2_OnMovementModeChanged" && ((*(long*)Parms) & 0x400) == 0x400 && !controller.IsRidingFlyPal())
                {
                    System.Console.WriteLine("PLAYER TRYING TO FLY!");
                    KickPlayer(playerChar, controller);
                    return true;
                }
                if (funcName == "ReviveCharacter_ToServer")
                {
                    System.Console.WriteLine("PLAYER TRYING TO REVIVE HACK!");
                    KickPlayer(playerChar, controller);
                    return true;
                }
            }
            if (obj.IsA(out PalNetworkPlayerComponent netPlayer))
            {
                if (funcName == "RequestAddItem_ToServer")
                {
                    var frames = NativeNetSharp.NativeStackWalk.CaptureStackBackTrace();
                    foreach(var frame in frames)
                    {
                        System.Console.WriteLine(frame.address.ToString("X") + " : " + frame.module);
                    }
                    try
                    {
                        var callingFunc = frames.FirstOrDefault(f => f.module.Contains("PalServer-Win64-Test-Cmd"));
                        if (callingFunc?.address == UnrealEngine.ReceivedRPC) // called from c2s packet
                        {
                            System.Console.WriteLine("PLAYER TRYING TO INJECT ITEM!");
                            //KickPlayer(playerChar, playerChar.Controller.As<PalPlayerController>());
                            return true;
                        }
                    }catch (Exception ex)
                    {
                        System.Console.WriteLine("ex : " + ex.Message);
                    }
                }
                if (funcName == "RegisterRespawnLocation_ToServer")
                {
                    System.Console.WriteLine("PLAYER TRYING TO REGISTER REPSAWN LOCATION!");
                    return true;

                }
                if (funcName == "RequestUnlockTechnology_ToServer")
                {
                    var players = World.GameState.PlayerArray;
                    for (var i = 0; i < players.Num; i++)
                    {
                        var playerState = players[i].As<PalPlayerState>();
                        var player = playerState.PawnPrivate.As<PalPlayerCharacter>();
                        var playerController = player.Controller.As<PalPlayerController>();
                        var netPlayerTemp = playerController.Transmitter.Player;
                        if (netPlayerTemp.Address == netPlayer.Address)
                        {
                            // enough points? NOTE - server does check this when saving, but client thinks he has it unlocked and can build still
                            var ancientPoints = playerState.TechnologyData.bossTechnologyPoint;
                            var techPoint = playerState.TechnologyData.TechnologyPoint;
                        }
                    }
                }
            }
            return false;
        }
        static World World;
        public static Int32 Main()
        {
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
                    World = new World(UnrealEngine.Memory.ReadProcessMemory<nint>(UnrealEngine.GWorldPtr)); if (!World.IsA<World>()) return 1;
                    var OwningGameInstance = World.OwningGameInstance.As<PalGameInstance>(); if (!OwningGameInstance.IsA<PalGameInstance>()) return 2;
                    System.Console.WriteLine("Hooking Game Instance");
                    World.HookProcessEvent();
                    var players = World.GameState.PlayerArray;
                    for(var i = 0; i < players.Num; i++)
                    {
                        var player = players[i];
                        System.Console.WriteLine("hooking player"); // sometimes this fails... also need to batch the hooks because of suspend thread
                        player.HookProcessEvent();
                        player.As<PalPlayerState>().PawnPrivate.HookProcessEvent();
                        player.As<PalPlayerState>().InventoryData.HookProcessEvent();
                        player.As<PalPlayerState>().TechnologyData.HookProcessEvent();
                        player.As<PalPlayerState>().PawnPrivate.Controller.HookProcessEvent();
                        player.As<PalPlayerState>().PawnPrivate.Controller.As<PalPlayerController>().Transmitter.HookProcessEvent();
                        player.As<PalPlayerState>().PawnPrivate.Controller.As<PalPlayerController>().Transmitter.Player.HookProcessEvent();
                        System.Console.WriteLine("hooked player");
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