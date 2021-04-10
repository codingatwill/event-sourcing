using System.Threading.Tasks;

namespace Coding.EventSourcing.Core
{
    public interface IEventListener
    {
        Task HandleAsync(IEventMessage message);
    }
}
