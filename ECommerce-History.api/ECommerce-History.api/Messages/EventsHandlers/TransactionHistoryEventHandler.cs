using appDist.Event.MQ.Src.Bus;
using ECommerce_History.api.Messages.Events;

namespace ECommerce_History.api.Messages.EventsHandlers
{
    public class TransactionHistoryEventHandler : IEventHandler<TransactionHistoryCreateEvent>
    {

        public TransactionHistoryEventHandler()
        {
            Console.WriteLine("constructor");
        }

        public Task Handle(TransactionHistoryCreateEvent @event)
        {
            var resultadoMQ = @event.CaterogiaParamDto;
            Console.WriteLine("***entro*");
            Console.WriteLine(resultadoMQ.Description);

            return Task.CompletedTask;
        }
    }
}
