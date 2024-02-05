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
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        MyContext mc= new MyContext();
        public EfBookingDal(MyContext context) : base(context)
        {
        }

        public void BookingStatusApproved(int id)
        {
            var values = mc.Bookings.Find(id);
            values.Description = "Rezervasyon Onaylandı";
            mc.SaveChanges();
        }

        public void BookingStatusCancelled(int id)
        {
            var values = mc.Bookings.Find(id);
            values.Description = "Rezervasyon İptal Edildi";
            mc.SaveChanges();
        }
    }
}
