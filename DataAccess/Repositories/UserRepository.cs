using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class UserRepository : RepositoryBase<Pokupatel>, IUserRepository
    {
        public UserRepository(InternetstoreContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
