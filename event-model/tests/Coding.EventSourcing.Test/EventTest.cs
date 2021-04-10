using Coding.EventSourcing.Core;
using NUnit.Framework;

namespace Coding.EventSourcing.Test
{
    public class Tests
    {
        private readonly IEventBus eventBus;
        private readonly IEventListener listener1;
        private readonly IEventListener listener2;
        private readonly IEventListener listener3;
        private readonly IEventListener listener4;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EventFlowTest()
        {
            var eventMessage = new EventMessage(new TestEvent());

            eventBus.PublishAsync(eventMessage);

            listener1.HandleAsync(eventMessage);
            listener3.HandleAsync(eventMessage);
            listener3.HandleAsync(eventMessage);
            listener4.HandleAsync(eventMessage);

            Assert.Pass();

        }
    }

    public class TestEvent : IEvent
    {
        
    }
}