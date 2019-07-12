using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace netassignment.Models
{
    public class Transactions : Account
    {
        public int ID { get; set; }
        public string AccountID { get; set; }
        public double Amount { get; set; }
        public char CreditDebitInd { get; set; }
    }
}