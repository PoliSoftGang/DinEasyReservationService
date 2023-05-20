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
    internal class PeculiarityRepository : BaseRepository<Peculiarity>, IPeculiarityRepository
    {
        public PeculiarityRepository(ReservationServiceDbContext context) : base(context)
        {
        }
    }
}

