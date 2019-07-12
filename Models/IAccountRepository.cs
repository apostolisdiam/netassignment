using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netassignment.Models
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAll();
        Account Get(int id);
        Account Add(Account item);
        void Remove(int id);
        bool Update(Account item);
    }
}
