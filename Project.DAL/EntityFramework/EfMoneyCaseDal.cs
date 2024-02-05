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
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
    {
        public EfMoneyCaseDal(MyContext context) : base(context)
        {
        }

        public decimal TotalMoneyCaseAmount()
        {
            using var context = new MyContext();
            return context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
        }
    }
}
