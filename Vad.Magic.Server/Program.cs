using System.ComponentModel;
using System.Resources;
using Vad.Magic.Server.Network.TCP;
using Vad.Magic.Titan.Logic.Debug;

namespace Vad.Magic.Server;

class Program
{
    private static readonly TaskCompletionSource<bool> _exitEvent = new TaskCompletionSource<bool>();

    public static async Task Main()
    {
        Program.Init();

        TCPGateway tcpGateway = new();
        tcpGateway.Start();

        await Program.WaitForExit();
        await tcpGateway.Stop();
    }

    private static void Init()
    {
        Program.DisplayBanner();
    }


    private static void DisplayBanner()
    {
        Console.WriteLine("""
                                                                                @@@
    @@@    @@                   @@@        @@@@@   @@@@@                        @@@           
    @@@@  @@@   @@@@@@@@        @@@        @@@@@@ @@@@@@    @@@@@@@  +@@@@@@@@       @@@@@@@  
     @@@ +@@         @@@   @@@@@@@@        @@@@@@@@@@@@@:       @@@  @@@   @@@  @@@  @@@      
     @@@@@@*    @@@@+@@@  @@@   @@@        @@@ @@@@@ @@@*  @@@@%@@@  @@@  .@@@  @@@  @@@      
      @@@@@    @@@@  @@@  @@@   @@@   @@@  @@@  @@@  @@@@  @@%  @@@  @@@@@@@@@  @@@  @@@      
      @@@@      @@@@@@@@   @@@@@@@@   @@@  @@@   @   @@@@  @@@@@@@@       @@@%  @@+   @@@@@@  
                                                                      @@@@@@#                         
    """);
        Console.WriteLine("With using Vad.NotCore.\n");

    }

    private static async Task WaitForExit()
    {
        await Program._exitEvent.Task;
    }

    private static void OnCancelKeyPress(object? sender, ConsoleCancelEventArgs eventArgs)
    {
        eventArgs.Cancel = true;
        Program._exitEvent.TrySetResult(true);
    }
}