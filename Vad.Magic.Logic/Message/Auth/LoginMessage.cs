using Vad.Magic.Titan.Logic.Math;
using Vad.Magic.Titan.Logic.Message;

namespace Vad.Magic.Logic.Message.Auth
{
    public class LoginMessage : PiranhaMessage
    {
        private LogicLong _accountId;
        private string _passToken;
        private int _clientMajorVersion;
        //ReadInt
        private int _clientBuild;
        private string _resourceSha;
        private string _UDID;
        private string _openUDID;
        private string _macAddress;
        private string _device;

        public override void Decode()
        {
            base.Decode();
            _accountId = this.stream.ReadLong();
            _passToken = this.stream.ReadString();
            _clientMajorVersion = this.stream.ReadInt();
            this.stream.ReadInt();
            _clientBuild = this.stream.ReadInt();
            _resourceSha = this.stream.ReadString();
            _UDID = this.stream.ReadString();
            _openUDID = this.stream.ReadString();
            _macAddress = this.stream.ReadString();
            _device = this.stream.ReadString();


        }

        public LogicLong GetAccountId()
        {
            return _accountId;
        }

        public string? GetPassToken()
        {
            return _passToken;
        }

        public int GetMajorVersion()
        {
            return _clientMajorVersion;
        }

        public int GetBuild()
        {
            return _clientBuild;
        }

        public string GetResourceSHA()
        {
            return _resourceSha;
        }

        public string GetDevice()
        {
            return _device;
        }

        public override int GetMessageType()
        {
            return 10101;
        }
    }
}
