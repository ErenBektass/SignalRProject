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
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        public EfNotificationDal(MyContext context) : base(context)
        {
        }

        public List<Notification> GetAllNotificationByFalse()
        {
            using var context = new MyContext();
            return context.Notifications.Where(x => x.Status == false).ToList();
        }

        public int NotificationCountByStatusFalse()
        {
            using var context = new MyContext();
            return context.Notifications.Where(x => x.Status == false).Count();
        }

        public void NotificationStatusChangeToFalse(int id)
        {
            using var context = new MyContext();
            var value = context.Notifications.Find(id);
            value.Status = false;
            context.SaveChanges();
        }

        public void NotificationStatusChangeToTrue(int id)
        {
            using var context = new MyContext();
            var value = context.Notifications.Find(id);
            value.Status = true;
            context.SaveChanges();
        }
    }
}
