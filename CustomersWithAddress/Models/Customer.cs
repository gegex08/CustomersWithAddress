using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomersWithAddress.Models {
    public class Customer {

        public string FirstName { get; set;}
        public string LastName { get; set; }
        public Address ShippingStreet { get; set; }
        public Address ShippingCity { get; set; }
        public Address BillingStreet { get; set; }
        public Address BillingCity { get; set; }
    }
}