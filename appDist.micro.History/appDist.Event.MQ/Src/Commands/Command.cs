using appDist.Event.MQ.Src.Events;
using System;

namespace appDist.Event.MQ.Src.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
