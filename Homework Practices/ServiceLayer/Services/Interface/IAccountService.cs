using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interface
{
    public interface IAccountService
    {
        string Login(string email, string password,int roleId);
    }
}
