using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders
{
    public static class CurrentUser
    {
        public static int Id { get; set; }
        public static string Username { get; set; }
        public static string Email { get; set; }
        public static string UserType { get; set; }
        public static DateTime DateRegister { get; set; }
    }

}
