using OrderService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Repositories
{
    public interface IOrderRepository
    {
        List<Orders> GetAll();
        Orders GetById(string item);
        void Add(Orders item);
        void Update(Orders item);
        void Delete(string obj);
      
    }
}
