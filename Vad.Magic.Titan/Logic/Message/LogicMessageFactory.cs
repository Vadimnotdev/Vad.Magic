namespace Vad.Magic.Titan.Logic.Message
{
    public abstract class LogicMessageFactory
    {
        public abstract PiranhaMessage? CreateMessageByType(int messageType);
    }
}
