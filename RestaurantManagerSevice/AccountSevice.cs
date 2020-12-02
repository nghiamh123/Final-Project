using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagerSevice
{
    public class AccountSevice
    {
        RestaurantManagerEntities db = new RestaurantManagerEntities();
        public Account login(String username,String pass)
        {
            Account account =(from ac in db.Accounts where ac.username == username && ac.pass == pass select ac).FirstOrDefault();
            return account;
        }

        public List<Account> getALLNV()
        {
            var list = db.Accounts.Where(ac => ac.role != 0);
            return list.ToList();
        }

        public void addNV(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
        }
    }
}
