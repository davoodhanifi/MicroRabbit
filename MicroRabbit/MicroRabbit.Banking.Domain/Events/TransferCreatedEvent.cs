using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int FromAccount
        {
            get;
            protected set;
        }

        public int ToAccount
        {
            get;
            protected set;
        }

        public decimal Amount
        {
            get;
            protected set;
        }

        public TransferCreatedEvent(int fromAccount, int toAccount, decimal amount)
        {
            FromAccount = fromAccount; 
            ToAccount = toAccount;  
            Amount = amount;
        }
    }
}
