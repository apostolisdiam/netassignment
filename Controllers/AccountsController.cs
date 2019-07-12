using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using netassignment.Models;

namespace netassignment.Controllers
{
    public class AccountsController : ApiController
    {
        static readonly IAccountRepository repository = new AccountRepository();

        public Account PostAccount (Account item)
        {
            item = repository.Add(item);
            return item;
        }
        

        public IEnumerable<Account> GetAllAccounts()
        {
            return repository.GetAll();
        }

        public Account GetAccount(int id) //for specific ID with /id
        {
            Account item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }
            
    }
}
