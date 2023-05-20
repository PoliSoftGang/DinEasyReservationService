using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    internal sealed class ReservationServiceDbContext : DbContext
    {
        public ReservationServiceDbContext(DbContextOptions options)
            : base(options)
        {
        }

        internal DbSet<Table> Tables { get; set; }
        internal DbSet<Reservation> Reservations { get; set; }
        internal DbSet<Peculiarity> Persistences { get; set; }
    }
}
