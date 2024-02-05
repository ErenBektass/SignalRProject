using Project.ENTITIES.Models;

namespace Project.BLL.Abstract
{
    public interface IDiscountService : IGenericService<Discount>
    {
        void TChangeStatusToTrue(int id);
        void TChangeStatusToFalse(int id);
        List<Discount> TGetListByStatusTrue();
    }
}
