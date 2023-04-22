using Domain.Interfaces;
using Domain.Models;
namespace BusinessLogic.Services
{ 
    public class UserService : IUserService
    {
        private IRepositoryWrapper _repositoryWrapper;
        public UserService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public async Task<List<Pokupatel>> GetAll()
        {    
            return await _repositoryWrapper.Pokupatel.FindAll();
        }
        public async Task<Pokupatel> GetById(int id)
        {
            var user = await _repositoryWrapper.Pokupatel
            .FindByCondition(x => x.IdPokupatel == id);
            return user.First();
        }
        public async Task Create(Pokupatel model)
        {
            await _repositoryWrapper.Pokupatel.Create(model);
            _repositoryWrapper.Save();
        }
        public async Task Update(Pokupatel model)
        {
            _repositoryWrapper.Pokupatel.Update(model);
            _repositoryWrapper.Save();
        }
        public async Task Delete(int id)
        {
            var user = await _repositoryWrapper.Pokupatel
            .FindByCondition(x => x.IdPokupatel == id);
            _repositoryWrapper.Pokupatel.Delete(user.First());
            _repositoryWrapper.Save();
        }
    }
}