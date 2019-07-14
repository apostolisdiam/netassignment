using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace netassignment.Models
{
    public class TransactionsRepository : ITransactionsRepository
    {
        private List<Transactions> transact = new List<Transactions>();
        private int transactionid = 1;

        public TransactionsRepository()
        {
            transact.Add(new Transactions { ID = 1, AccountID = "opseos", Amount = 850, CreditDebitInd = 'C' });
            transact.Add(new Transactions { ID = 2, AccountID = "tamieutirio", Amount = 243, CreditDebitInd = 'D' });
            transact.Add(new Transactions { ID = 3, AccountID = "misthodosia", Amount = 778, CreditDebitInd = 'D' });
        }

        public IEnumerable<Transactions> GetAll()
        {
            return transact;
        }

        public Transactions Get(int id)
        {
            return transact.Find(t => t.ID == id);

        }

        public Transactions Add(Transactions item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.ID = transactionid++;
            transact.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            transact.RemoveAll(t => t.ID == id);
        }

        public bool Update(Transactions item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = transact.FindIndex(t => t.ID == item.ID);
            if (index == -1)
            {
                return false;
            }
            transact.RemoveAt(index);
            transact.Add(item);
            return true;


        }
    }
}