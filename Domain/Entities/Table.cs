using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Table : Entity
    {
        public int SeatsNumber { get; set; }
        public int TableNumber { get; set; }
        public bool Availability { get; set; }

        public IEnumerable<Reservation>? Reservations { get; set; }
    }
}
