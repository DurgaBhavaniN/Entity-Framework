using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIPRATICE.Models;
namespace APIPRATICE.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerDBContext db = new CustomerDBContext();
        //getting all customers
        [HttpGet]
        [Route("GetAll")]
        public List<Customer> GetAllCustomers()
        {
            return db.Customer.ToList();
        }
        [HttpGet("{id}")]
        [Route("GetById/{id}")]
        public Customer GetCustomerById(string id)
        {
            return db.Customer.Find(id);
        }
        [HttpGet("{city}")]
        [Route("GetByCity/{city}")]
        public List<Customer> GetCustomerByCity(string city)
        {
            return db.Customer.Where(e => e.City == city).ToList();
        }
        [HttpPost]
        [Route("AddCustomer")]
        public void AddCustomer(Customer item)
        {
           
            db.Add(item);
            db.SaveChanges();
        }
        [HttpPut]
        [Route("Update/{id}")]
        public void Update(string id)
        {
            Customer c= db.Customer.Find(id);
            c.Address = "Vijaz";
            db.Customer.Update(c);
            db.SaveChanges();
        }

    }
}