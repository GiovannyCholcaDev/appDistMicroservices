using appDist.Event.MQ.Src.Events;
using System.Threading.Tasks;

namespace appDist.Event.MQ.Src.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
         where TEvent : appDist.Event.MQ.Src.Events.Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}
