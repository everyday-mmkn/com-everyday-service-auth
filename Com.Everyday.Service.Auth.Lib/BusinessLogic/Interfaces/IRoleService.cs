using Com.Everyday.Service.Auth.Lib.Models;
using Com.Everyday.Service.Auth.Lib.Utilities.BaseInterface;
using Com.Everyday.Service.Auth.Lib.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Everyday.Service.Auth.Lib.BusinessLogic.Interfaces
{
    public interface IRoleService : IBaseService<Role>
    {
        bool CheckDuplicate(int id, string code);
    }
}
