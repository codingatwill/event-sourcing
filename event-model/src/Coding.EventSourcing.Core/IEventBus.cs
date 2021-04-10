using System.Threading.Tasks;

namespace Coding.EventSourcing.Core
{
    public interface IEventBus
    {
        Task PublishAsync(IEventMessage eventMessage);
    }
}
