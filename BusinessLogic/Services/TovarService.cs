using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
     public class TovarService : ITovarService
        {
            private IRepositoryWrapper _repositoryWrapper;
            public TovarService(IRepositoryWrapper repositoryWrapper)
            {
                _repositoryWrapper = repositoryWrapper;
            }
            public async Task<List<Tovar>> GetAll()
            {
                return await _repositoryWrapper.Tovar.FindAll();
            }
            public async Task<Tovar> GetById(int id, int id1)
            {
                var user = await _repositoryWrapper.Tovar
                .FindByCondition(x => x.IdTovara == id && x.IdKategorii == id1);
                return user.First();
            }
            public async Task Create(Tovar model)
            {
                await _repositoryWrapper.Tovar.Create(model);
                _repositoryWrapper.Save();
            }
            public async Task Update(Tovar model)
            {
                _repositoryWrapper.Tovar.Update(model);
                _repositoryWrapper.Save();
            }
            public async Task Delete(int id)
            {
                var user = await _repositoryWrapper.Tovar
                .FindByCondition(x => x.IdTovara == id);
                _repositoryWrapper.Tovar.Delete(user.First());
                _repositoryWrapper.Save();
        }
        }
    }
