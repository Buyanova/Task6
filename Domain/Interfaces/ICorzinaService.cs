using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICorzinaService
    {
        Task<List<Corzina>> GetAll();
        Task<Corzina> GetById(int id, int id1);
        Task Create(Corzina mkodel);
        Task Update(Corzina model);
        Task Delete(int id, int id1);
    }
}
