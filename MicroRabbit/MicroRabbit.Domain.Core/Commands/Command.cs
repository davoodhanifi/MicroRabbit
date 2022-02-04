using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime DateTime
        {
            get;
            protected set;
        }

        public Command()
        {
            DateTime = DateTime.Now;
        }
    }
}
