using Vad.Magic.Titan.Logic.Math;
using Vad.Magic.Titan.Logic.Message;

namespace Vad.Magic.Logic.Message.Auth;

public class LoginOkMessage : PiranhaMessage
{
    public LogicLong _accountId;
    public LogicLong _homeId;
    public string _passToken;
    public string _facebookId;
    public string _gamecenterId;
    public int _serverMajorVersion;
    public int _serverBuild;
    public int _contentVersion;
    public string _serverEnvironment;
    public int _sessionCount;
    public int _playTimeSeconds;
    public int _daysSinceStartedPlayingl;



    public LoginOkMessage() : base(0)
    {
        this._accountId = new LogicLong(0, 1);
        this._homeId = new LogicLong(0, 1);
        this._passToken = "PassToken";
        this._facebookId = "FacebookId";
        this._gamecenterId = "GamecenterId";
        this._serverMajorVersion = 1;
        this._serverBuild = 70;
        this._contentVersion = 1;
        this._serverEnvironment = "ServerEnvironment";
        this._sessionCount = 1;
        this._playTimeSeconds = 1;
        this._daysSinceStartedPlayingl = 1;

    }

    public override void Encode()
    {
        base.Encode();
        this.stream.WriteLong(this._accountId);
        this.stream.WriteLong(this._homeId);
        this.stream.WriteString(this._passToken);
        this.stream.WriteString(this._facebookId);
        this.stream.WriteString(this._gamecenterId);
        this.stream.WriteInt(this._serverMajorVersion);
        this.stream.WriteInt(this._serverBuild);
        this.stream.WriteInt(this._contentVersion);
        this.stream.WriteString(this._serverEnvironment);
        this.stream.WriteInt(this._sessionCount);
        this.stream.WriteInt(this._playTimeSeconds);
        this.stream.WriteInt(this._daysSinceStartedPlayingl);


    }

    public override int GetMessageType()
    {
        return 20104;
    }

}