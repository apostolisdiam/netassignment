using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using netassignment.Models;


namespace netassignment.Controllers
{
    public class TransactionsController : ApiController
    {
        static readonly ITransactionsRepository trepository = new TransactionsRepository();

        public Transactions PostTransactions(Transactions item)
        {
            item = trepository.Add(item);
            return item;
        }

        public IEnumerable<Transactions> GetAllTransactions()
        {
            return trepository.GetAll();
        }

        public Transactions GetAccount(int id) //for specific ID with /id
        {
            Transactions item = trepository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }
    }
}
