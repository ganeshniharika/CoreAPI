using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Models
{
   public interface Icustomer
    {
        IEnumerable<Customer> create(Customer c);
        IEnumerable<Customer> delete(int id);
        Customer getbyid(int id);
        Customer updatebyid(int id);



    }
}
