using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApplication.Data
{
    public class SessionState
    {
        public int UserId { get; set; }
        
        public string Username { get; set; }

        public string Email { get; set; }

        public bool EnableLoader { get; set; }

        public bool IsAuthenticated { get; set; }
    }
}
