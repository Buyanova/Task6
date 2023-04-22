using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IHaracterysticaService
    {
        Task<List<HaracterysticaTovarov>> GetAll();
        Task<HaracterysticaTovarov> GetById(int id);
        Task Create(HaracterysticaTovarov mkodel);
        Task Update(HaracterysticaTovarov model);
        Task Delete(int id);
    }
}
