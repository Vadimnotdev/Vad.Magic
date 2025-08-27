using System.Net.Sockets;

namespace Vad.Magic.Server.Network.Extensions;

internal static class SocketExtension
{
    public static async ValueTask<Socket?> AcceptSocketAsync(this Socket socket, CancellationToken ct)
    {
        try
        {
            return await socket.AcceptAsync(ct);
        }
        catch (OperationCanceledException)
        {
            return null;
        }
    }
}