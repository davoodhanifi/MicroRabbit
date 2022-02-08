using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferLogRepository _transferLogRepository;
        public TransferEventHandler(ITransferLogRepository transferLogRepository)
        {
            _transferLogRepository = transferLogRepository;
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            var transferLog = new TransferLog
            {
                FromAccount = @event.FromAccount,
                ToAccount = @event.ToAccount,
                Amount = @event.Amount
            };

            _transferLogRepository.Add(transferLog);
            return Task.CompletedTask;
        }
    }
}
