using System;
using System.Collections.Generic;
using System.Reflection;

namespace Domain.Entites
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }

    }
}
