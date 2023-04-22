using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IUserService
    {
        Task<List<Pokupatel>> GetAll();
        Task<Pokupatel> GetById(int id);
        Task Create(Pokupatel mkodel);
        Task Update(Pokupatel model);
        Task Delete(int id);
    }
}
