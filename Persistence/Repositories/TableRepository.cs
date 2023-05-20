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
    internal class TableRepository : BaseRepository<Table>, ITableRepository
    {
        public TableRepository(ReservationServiceDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Table>> GetAllAsync(bool onlyAvailable = false)
        {
            if (onlyAvailable) return await base.GetAllAsync();
            return await _dbContext.Tables.Where(x => x.Availability).ToListAsync();
        }
    }
}

