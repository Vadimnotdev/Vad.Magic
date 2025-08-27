namespace Vad.Magic.Logic.Message
{
    using Vad.Magic.Logic.Message;
    using Vad.Magic.Titan.Logic.Message;
    using Vad.Magic.Logic.Message.Auth;

    public class LogicMagicMessageFactory : LogicMessageFactory
    {
        public static LogicMagicMessageFactory Instance;

        static LogicMagicMessageFactory()
        {
            Instance = new LogicMagicMessageFactory();
        }


        private readonly Dictionary<int, Type> _allMessages;
        public LogicMagicMessageFactory() : base()
        {
            _allMessages = new Dictionary<int, Type> {
                { 10101, typeof(LoginMessage) }
            };
        }

        public override PiranhaMessage? CreateMessageByType(int messageType)
        {
            if (_allMessages.ContainsKey(messageType))
            {
                return Activator.CreateInstance(_allMessages[messageType]) as PiranhaMessage;
            }
            else
            {
                return null;
            }
        }

        public void Destruct()
        {
            throw new NotImplementedException();
        }
    }
}