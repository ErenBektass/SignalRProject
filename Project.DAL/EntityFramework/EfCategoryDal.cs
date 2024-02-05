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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(MyContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using var context = new MyContext();
            return context.Categories.Where(x => x.Status == true).Count();
        }

        public int CategoryCount()
        {
            using var context = new MyContext();
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new MyContext();
            return context.Categories.Where(x => x.Status == false).Count();
        }
    }
}
