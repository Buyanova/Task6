using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class ZakazService : IZakazService
    {
        private IRepositoryWrapper _repositoryWrapper;
        public ZakazService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public async Task<List<Zakaz>> GetAll()
        {
            return await _repositoryWrapper.Zakaz.FindAll();
        }
        public async Task<Zakaz> GetById(int idz, int idp)
        {
            var user = await _repositoryWrapper.Zakaz
            .FindByCondition(x => x.IdZakaz == idz && x.IdPokupatel == idp);
            return user.First();
        }
        public async Task Create(Zakaz model)
        {
            await _repositoryWrapper.Zakaz.Create(model);
            _repositoryWrapper.Save();
        }
        public async Task Update(Zakaz model)
        {
            _repositoryWrapper.Zakaz.Update(model);
            _repositoryWrapper.Save();
        }
        public async Task Delete(int id)
        {
            var user = await _repositoryWrapper.Zakaz
            .FindByCondition(x => x.IdZakaz == id);
            _repositoryWrapper.Zakaz.Delete(user.First());
            _repositoryWrapper.Save();
        }
    }
}
