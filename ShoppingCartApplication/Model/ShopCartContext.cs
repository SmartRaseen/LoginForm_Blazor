using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApplication.Model
{
    public class ShopCartContext : DbContext
    {
        public ShopCartContext(DbContextOptions<ShopCartContext> options)
            : base(options)
        {

        }

        public DbSet<LoginInfo> Users { get; set; }

        public DbSet<RegisterInfo> Register { get; set; }
    }
}
