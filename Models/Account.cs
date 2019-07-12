using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace netassignment.Models
{
    public class Account
    {
        public int ID { get; set;}
        public string UserID { get; set; }
        public string IBAN { get; set; }
        public double Balance { get; set; }
    }
}