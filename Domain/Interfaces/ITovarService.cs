using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ITovarService
    {
        Task<List<Tovar>> GetAll();
        Task<Tovar> GetById(int id, int id1);
        Task Create(Tovar mkodel);
        Task Update(Tovar model);
        Task Delete(int id);
    }
}
