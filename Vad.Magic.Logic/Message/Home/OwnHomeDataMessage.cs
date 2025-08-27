using System.IO;
using Vad.Magic.Logic.Avatar;
using Vad.Magic.Logic.Home;
using Vad.Magic.Titan.Logic.Message;

namespace Vad.Magic.Logic.Message.Home
{
    public class OwnHomeDataMessage : PiranhaMessage
    {
        public LogicClientHome _logicClientHome = new();
        public LogicClientAvatar _logicClientAvatar = new();
        private int _secondsSinceLastSave = 0;

        public OwnHomeDataMessage() : base(0)
        {
        }

        public override void Encode()
        {
            base.Encode();
            this.stream.WriteInt(_secondsSinceLastSave);
            _logicClientHome.Encode(stream);
            _logicClientAvatar.Encode(stream);
        }

        public override int GetMessageType()
        {
            return 24101;
        }

    }
}
