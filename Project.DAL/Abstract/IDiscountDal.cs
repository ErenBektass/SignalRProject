using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Abstract
{
    public interface IDiscountDal : IGenericDal<Discount>
    {
        void ChangeStatusToTrue(int id);
        void ChangeStatusToFalse(int id);
        List<Discount> GetListByStatusTrue();
    }
}
