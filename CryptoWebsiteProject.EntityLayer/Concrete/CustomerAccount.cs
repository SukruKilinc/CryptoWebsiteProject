﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWebsiteProject.EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CustomerAccountCurrency { get; set; }
        public decimal CustomerAccountBalance { get; set; }
    }
}
