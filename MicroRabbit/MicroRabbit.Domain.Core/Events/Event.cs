using System;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime dateTime
        {
            get;
            protected set;
        }

        public Event()
        {
            dateTime = DateTime.Now;
        }
    }
}
