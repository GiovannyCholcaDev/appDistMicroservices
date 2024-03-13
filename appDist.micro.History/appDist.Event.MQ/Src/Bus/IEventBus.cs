using appDist.Event.MQ.Src.Commands;

namespace appDist.Event.MQ.Src.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : appDist.Event.MQ.Src.Events.Event;

        void Subscribe<T, TH>()
            where T : appDist.Event.MQ.Src.Events.Event
            where TH : IEventHandler<T>;
    }
}
