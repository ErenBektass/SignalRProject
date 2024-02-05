using Project.ENTITIES.Models;

namespace Project.BLL.Abstract
{
    public interface IMenuTableService : IGenericService<MenuTable>
    {
        int TMenuTableCount();
    }
}
