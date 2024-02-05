using Project.ENTITIES.Models;

namespace Project.BLL.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        int TCategoryCount();
        int TActiveCategoryCount();
        int TPassiveCategoryCount();
    }
}
