using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.DAL.Repositories;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(MyContext context) : base(context)
        {
        }

        public int ActiveOrderCount()
        {
            using var context = new MyContext();
            return context.Orders.Where(x => x.Description == "Müşteri Masada").Count();
        }

        public decimal LastOrderPrice()
        {
            using var context = new MyContext();
            return context.Orders.OrderByDescending(x => x.OrderID).Take(1).Select(y => y.TotalPrice).FirstOrDefault();
        }

        public decimal TodayTotalPrice()
        {
            return 0;
        }

        public int TotalOrderCount()
        {
            using var context = new MyContext();
            return context.Orders.Count();
        }
    }
}
