namespace Coding.EventSourcing.Core
{
    public interface IEventMessage
    {
        IEvent Event { get; }
    }


    public class EventMessage : IEventMessage
    {
        public IEvent Event { get; }

        public EventMessage(IEvent @event)
        {
            Event = @event;
        }

        IEvent IEventMessage.Event => Event;
    }
}
