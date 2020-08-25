using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebAPI.Controllers
{
    [Route("/")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        Icustomer cus;
        public CustomerController(Icustomer cus)   // here Constructor injection is happenning check with design principle (dip)
        {
            this.cus = cus;
        }
        [HttpPost]
        public IEnumerable<Customer> createCustomerdata(Customer cust)
        {
            IEnumerable<Customer> listcus = cus.create(cust);
            
            return listcus;
        }
        [HttpDelete]
        public IEnumerable<Customer> deleteCustomerdata(int id)
        {
            IEnumerable<Customer> dellist = cus.delete(id);
            return dellist;
        }
        [HttpGet]
        public Customer getbyid(int id)
        {
            Customer idcus = cus.getbyid(id);
            return idcus;
                 
        }
        [HttpPut]
        public Customer updatebyid(int id)
        {
            Customer upcus = cus.updatebyid(id);
            return upcus;

        }

    }
}
