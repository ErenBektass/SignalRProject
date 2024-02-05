using Project.ENTITIES.Models;

namespace Project.BLL.Abstract
{
    public interface IMoneyCaseService : IGenericService<MoneyCase>
    {
        decimal TTotalMoneyCaseAmount();
    }
}
