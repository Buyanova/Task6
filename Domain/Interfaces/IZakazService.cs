using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IZakazService
    {
        Task<List<Zakaz>> GetAll();
        Task<Zakaz> GetById(int idz, int idp);
        Task Create(Zakaz mkodel);
        Task Update(Zakaz model);
        Task Delete(int idz);
    }
}
