using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class CorzinaService : ICorzinaService
    {
        private IRepositoryWrapper _repositoryWrapper;
        public CorzinaService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public async Task<List<Corzina>> GetAll()
        {
            return await _repositoryWrapper.Corzina.FindAll();
        }
        public async Task<Corzina> GetById(int id, int id1)
        {
            var user = await _repositoryWrapper.Corzina
            .FindByCondition(x => x.IdZakaz == id && x.IdTovara == id1);
            return user.First();
        }
        public async Task Create(Corzina model)
        {
            await _repositoryWrapper.Corzina.Create(model);
            _repositoryWrapper.Save();
        }
        public async Task Update(Corzina model)
        {
            _repositoryWrapper.Corzina.Update(model);
            _repositoryWrapper.Save();
        }
        public async Task Delete(int id, int id1)
        {
            var user = await _repositoryWrapper.Corzina
            .FindByCondition(x => x.IdZakaz == id && x.IdTovara == id1);
            _repositoryWrapper.Corzina.Delete(user.First());
            _repositoryWrapper.Save();
        }
    }
}
