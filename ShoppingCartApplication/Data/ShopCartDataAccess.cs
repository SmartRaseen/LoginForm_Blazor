using Microsoft.EntityFrameworkCore;
using ShoppingCartApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApplication.Data
{
    public class ShopCartDataAccess
    {
        private readonly ShopCartContext db;

        public ShopCartDataAccess(ShopCartContext dbContext)
        {
            db = dbContext;
        }

        #region User

        // Check the user exist
        public async Task<LoginInfo> CheckUserExist(LoginInfo user)
        {
            try
            {
                return await db.Users.Where(e => e.Username == user.Username && e.Password == user.Password).FirstOrDefaultAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> AddNewUser(RegisterInfo registeredUser)
        {
            try
            {   bool isUserExist = await db.Register.AnyAsync(e => e.Username == registeredUser.Username || e.Email == registeredUser.Email);
                if (!isUserExist)
                {
                    await db.Register.AddAsync(registeredUser);
                    var user = new LoginInfo()
                    {
                        Username = registeredUser.Username,
                        Password = registeredUser.Password
                    };
                    await db.Users.AddAsync(user);
                    await db.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<RegisterInfo> GetUserDetails(int id)
        {
            try
            {
                return await db.Register.Where(e => e.Id == id).FirstOrDefaultAsync();
            }
            catch
            {
                throw;
            }
        }

        #endregion
    }
}
