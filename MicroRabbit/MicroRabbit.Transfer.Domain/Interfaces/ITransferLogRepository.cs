using MicroRabbit.Transfer.Domain.Models;
using System;

namespace MicroRabbit.Transfer.Domain.Interfaces
{
    public interface ITransferLogRepository
    {
        void Add(TransferLog log);

        IEnumerable<TransferLog> GetTransferLogs();
    }
}
