using ShoppingCartApplication.Data;
using ShoppingCartApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApplication.Services
{
    public class ShopCartService
    {

        private readonly ShopCartDataAccess objDataAccess;

        public ShopCartService(ShopCartDataAccess dataAccess)
        {
            objDataAccess = dataAccess;
        }

        #region Users

        public async Task<LoginInfo> CheckUserExist(LoginInfo user)
        {
            return await objDataAccess.CheckUserExist(user);
        }

        public async Task<bool> AddNewUser(RegisterInfo registeredUser)
        {
            return await objDataAccess.AddNewUser(registeredUser);
        }

        public async Task<RegisterInfo> GetUserDetails(int id)
        {
            return await objDataAccess.GetUserDetails(id);
        }

        #endregion
    }
}
