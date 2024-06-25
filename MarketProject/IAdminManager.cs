using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal interface IAdminManager
    {
        public void AddCashier(Users usersBaseEntity, List<Users> cashier);
        public void AddAdmin(Users usersBaseEntity,List<Users> admin);
        public void AddSeller(Users usersBaseEntity,List<Users> seller);
    }
}
