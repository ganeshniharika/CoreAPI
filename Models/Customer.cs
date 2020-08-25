using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Models
{
    public class Customer
    {
        public int Cus_ID { get; set; }
        public String Cus_Name { get; set; }
        public int order_cost { get; set; }
    }
}
