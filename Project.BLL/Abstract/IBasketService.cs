using Project.ENTITIES.Models;

namespace Project.BLL.Abstract
{
    public interface IBasketService : IGenericService<Basket>
    {
        List<Basket> TGetBasketByMenuTableNumber(int id);
    }
}
