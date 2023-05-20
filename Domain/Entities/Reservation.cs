using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Reservation : Entity
    {
        public DateTime Date { get; set; }
        public int PeopleQuantity { get; set; }

        public IEnumerable<Peculiarity>? Peculiarities { get; set; }
        public IEnumerable<Table> Tables { get; set; } = new List<Table>();
    }
}
