﻿using Project.ENTITIES.Models;

namespace Project.BLL.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void BookingStatusApproved(int id);
        void BookingStatusCancelled(int id);
    }
}
