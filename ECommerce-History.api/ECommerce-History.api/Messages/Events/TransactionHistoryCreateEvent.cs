using appDist.Event.MQ.Src.Events;
using ECommerce_History.api.Dto;

namespace ECommerce_History.api.Messages.Events
{
    public class TransactionHistoryCreateEvent : Event
    {

        public CategoryDto CaterogiaParamDto { get; set; }


        public TransactionHistoryCreateEvent(CategoryDto caterogiaParamDto) {

            CaterogiaParamDto = caterogiaParamDto;
        }
    }
}
