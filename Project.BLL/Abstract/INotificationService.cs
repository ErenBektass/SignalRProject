using Project.ENTITIES.Models;

namespace Project.BLL.Abstract
{
    public interface INotificationService : IGenericService<Notification>
    {
        int TNotificationCountByStatusFalse();
        List<Notification> TGetAllNotificationByFalse();
        void TNotificationStatusChangeToTrue(int id);
        void TNotificationStatusChangeToFalse(int id);
    }
}
