using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netassignment.Models
{
    interface ITransactionsRepository
    {
        IEnumerable<Transactions> GetAll();
        Transactions Get(int id);
        Transactions Add(Transactions item);
        void Remove(int id);
        bool Update(Transactions item);
    }
}
