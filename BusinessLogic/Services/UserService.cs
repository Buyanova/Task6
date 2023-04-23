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
            if(model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            if(string.IsNullOrEmpty(model.Fio))
            {
                throw new ArgumentException(nameof(model.Fio));
            }

            if (string.IsNullOrEmpty(model.Email))
            {
                throw new ArgumentException(nameof(model.Email));
            }

            if (string.IsNullOrEmpty(model.Adres))
            {
                throw new ArgumentException(nameof(model.Adres));
            }

            if (string.IsNullOrEmpty(model.Phone))
            {
                throw new ArgumentException(nameof(model.Phone));
            }

            if (string.IsNullOrEmpty(model.Password))
            {
                throw new ArgumentException(nameof(model.Password));
            }

            await _repositoryWrapper.Pokupatel.Create(model);
            await _repositoryWrapper.Save();
        }
        public async Task Update(Pokupatel model)
        {
            await _repositoryWrapper.Pokupatel.Update(model);
            await _repositoryWrapper.Save();
        }
        public async Task Delete(int id)
        {
            var user = await _repositoryWrapper.Pokupatel
            .FindByCondition(x => x.IdPokupatel == id);
            await _repositoryWrapper.Pokupatel.Delete(user.First());
            await _repositoryWrapper.Save();
        }
    }
}