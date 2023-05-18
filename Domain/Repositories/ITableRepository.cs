using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ITableRepository
    {
        Task<IEnumerable<Table>> GetAllAsync(bool onlyAvailable = false);
        Task<Table> GetByIdAsync(int id);
        Table Update(Table table);
        void Add(Table table);
        void Remove(Table table);
    }
}
