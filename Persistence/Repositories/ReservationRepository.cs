using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    internal class ReservationRepository : BaseRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(ReservationServiceDbContext context) : base(context)
        {
        }
    }
}

