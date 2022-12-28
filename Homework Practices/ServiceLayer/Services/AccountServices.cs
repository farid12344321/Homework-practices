using ServiceLayer.Helpers.Constans;
using ServiceLayer.Helpers.Enums;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AccountServices : IAccountService
    {
       

        public string Login(string email, string password,int roleId)
        {
          if(email == AccountDatas.Email && password == AccountDatas.Password)
            {
                if (ChehkRole(roleId))
                {
                    return ResponseMessages.Success;
                }
                else
                {
                    return ResponseMessages.Unauthorized;
                }
            }
            return ResponseMessages.Falled;
        }



        private bool ChehkRole(int roleId)
        {
            if (roleId == (int)Roles.SuperAdmin)

                return true;
            return false;
        }
    }
}
