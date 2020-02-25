using OrderService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ShopDBContext _context;
        public OrderRepository(ShopDBContext context)
        {
            _context = context;
        }
        public void Add(Orders item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Delete(string obj)
        {
            Orders r = _context.Orders.Find(obj);
            _context.Remove(r);
            _context.SaveChanges();

        }

        public List<Orders> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Orders GetById(string id)
        {
            return _context.Orders.Find(id);
        }

        public void Update(Orders id)
        {
            _context.Orders.Update(id);
            _context.SaveChanges();
        }
    }
}
