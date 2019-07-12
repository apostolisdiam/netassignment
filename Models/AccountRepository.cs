using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace netassignment.Models
{
    public class AccountRepository : IAccountRepository
    {
        private List<Account> accounts = new List<Account>();
        private int accid = 1;
      
        public AccountRepository()
        {
            accounts.Add(new Account { ID = 1, UserID = "Apostolis", IBAN = "GR10", Balance = 200.53 });
            accounts.Add(new Account { ID = 2, UserID = "Nikos", IBAN = "GR18", Balance = 157.42 });
            accounts.Add(new Account { ID = 3, UserID = "Petros", IBAN = "GR25", Balance = 2037.45 });
        }

        public IEnumerable<Account> GetAll()
        {
            return accounts;

        }

        public Account Get(int id)
        {
            return accounts.Find(a => a.ID == id);
        }

        public Account Add(Account item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.ID = accid++;
            accounts.Add(item);
            return item;
        }

        public void Remove (int id)
        {
            accounts.RemoveAll(a => a.ID == id);
        }

        public bool Update(Account item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = accounts.FindIndex(a => a.ID == item.ID);
            if (index == -1)
            {
                return false;
            }
            accounts.RemoveAt(index);
            accounts.Add(item);
            return true;
        }
    }
}