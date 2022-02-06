using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Interfaces;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferLogRepository _transferLogRepository;
        private readonly IEventBus _eventBus;

        public TransferService(ITransferLogRepository transferLogRepository, IEventBus eventBus)
        {
            _transferLogRepository = transferLogRepository;
            _eventBus=eventBus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferLogRepository.GetTransferLogs();
        }
    }
}
