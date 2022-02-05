﻿using MicroRabbit.Banking.Domain.Models;
using System;

namespace MicroRabbit.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
