﻿using Com.Everyday.Service.Auth.Lib.Models;
using Com.Everyday.Service.Auth.Lib.Utilities.BaseInterface;
using Com.Everyday.Service.Auth.Lib.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Everyday.Service.Auth.Lib.BusinessLogic.Interfaces
{
    public interface IAccountService : IBaseService<Account>
    {
        Task<Account> Authenticate(string username, string password);

        bool CheckDuplicate(int id, string username);
    }
}
