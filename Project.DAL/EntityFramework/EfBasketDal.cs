using Microsoft.EntityFrameworkCore;
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
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(MyContext context) : base(context)
        {
        }

        public List<Basket> GetBasketByMenuTableNumber(int id)
        {
            using var context = new MyContext();
            var values = context.Baskets.Where(x => x.MenuTableID == id).Include(y => y.Product).ToList();
            return values;
        }
    }
}
