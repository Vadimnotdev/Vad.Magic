using Vad.Magic.Server.Network.Connection;
using Vad.Magic.Titan.Logic.Debug;
using Vad.Magic.Titan.Logic.Message;
using Vad.Magic.Logic.Message.Auth;
using Vad.Magic.Titan.Logic.Math;
using Vad.Magic.Logic.Message.Home;


namespace Vad.Magic.Server.Protocol;

class MessageManager
{
    private ClientConnection _connection;

    public MessageManager(ClientConnection connection)
    {
        this._connection = connection;
    }

    public async Task ReceiveMessage(PiranhaMessage message)
    {
        int messageType = message.GetMessageType();

        if (messageType != 14102)
            Debugger.Log($"MessageManager.ReceiveMessage: type={messageType}, name=" + message.GetType().Name);

        switch (message.GetMessageType())
        {
            case 10101:
                await this.OnLoginMessageReceived((LoginMessage)message);
                break;
        }
    }

    private async Task OnLoginMessageReceived(LoginMessage loginMessage)
    {

        Debugger.Log($"New client! AccountId={loginMessage.GetAccountId()}, passToken={loginMessage.GetPassToken()}, client version={loginMessage.GetMajorVersion()}.{loginMessage.GetBuild()}, Device={loginMessage.GetDevice()}");
        Debugger.Log($"client sha={loginMessage.GetResourceSHA()}");

        LoginOkMessage loginOkMessage = new LoginOkMessage();
        OwnHomeDataMessage ownHomeDataMessage = new OwnHomeDataMessage();

        await _connection.SendMessage(loginOkMessage);
        await _connection.SendMessage(ownHomeDataMessage);

    }

}