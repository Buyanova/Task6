using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class HaracterysticaService : IHaracterysticaService
    {
        private IRepositoryWrapper _repositoryWrapper;
        public HaracterysticaService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public async Task<List<HaracterysticaTovarov>> GetAll()
        {
            return await _repositoryWrapper.Haracterystica.FindAll();
        }
        public async Task<HaracterysticaTovarov> GetById(int id)
        {
            var user = await _repositoryWrapper.Haracterystica
            .FindByCondition(x => x.IdKategorii == id);
            return user.First();
        }
        public async Task Create(HaracterysticaTovarov model)
        {
            await _repositoryWrapper.Haracterystica.Create(model);
            _repositoryWrapper.Save();
        }
        public async Task Update(HaracterysticaTovarov model)
        {
            _repositoryWrapper.Haracterystica.Update(model);
            _repositoryWrapper.Save();
        }
        public async Task Delete(int id)
        {
            var user = await _repositoryWrapper.Haracterystica
            .FindByCondition(x => x.IdKategorii == id);
            _repositoryWrapper.Haracterystica.Delete(user.First());
            _repositoryWrapper.Save();
        }
    }
}
