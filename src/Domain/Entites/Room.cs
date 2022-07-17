using System.Collections.Generic;

namespace Domain.Entites
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
