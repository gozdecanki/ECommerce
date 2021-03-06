﻿using System;

namespace ECommerce.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; set; }
        IOutgoingEmailRepository OutgoingEmailRepository { get; set; }
        ICategoryRepository CategoryRepository { get; set; }
        IMenuRepository MenuRepository { get; set; }
        ILogRepository LogRepository { get; set; }
        int Complete();
    }
}