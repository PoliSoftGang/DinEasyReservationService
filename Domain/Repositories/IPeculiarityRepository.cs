using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IPeculiarityRepository
    {
        Task<IEnumerable<Peculiarity>> GetAllAsync();
        Task<Peculiarity?> GetByIdAsync(int id);
        Peculiarity Update(Peculiarity peculiarity);
        void Add(Peculiarity peculiarity);
    }
}
