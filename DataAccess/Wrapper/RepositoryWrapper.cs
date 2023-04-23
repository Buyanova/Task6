using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using DataAccess.Repositories;
using Domain.Models;

namespace DataAccess.Wrapper
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private InternetstoreContext _repoContext;

        private IUserRepository _pokupatel;
        public IUserRepository Pokupatel
        {
            get
            {
                if (_pokupatel == null)
                {
                    _pokupatel = new UserRepository(_repoContext);
                }
                return _pokupatel;
            }
        }

        private IHaracterysticaRepisitory _har;
        public IHaracterysticaRepisitory Haracterystica
        {
            get
            {
                if (_har == null)
                {
                    _har = new HaracterysticaRepisitory(_repoContext);
                }
                return _har;
            }
        }

        private ITovarRepisitory _t;
        public ITovarRepisitory Tovar
        {
            get
            {
                if (_t == null)
                {
                    _t = new TovarRepisitory(_repoContext);
                }
                return _t;
            }
        }

        private ICorzinaRepisitory _c;
        public ICorzinaRepisitory Corzina
        {
            get
            {
                if (_c == null)
                {
                    _c = new CorzinaRepisitory(_repoContext);
                }
                return _c;
            }
        }

        private IZakazRepisitory _z;
        public IZakazRepisitory Zakaz
        {
            get
            {
                if (_z == null)
                {
                    _z = new ZakazRepisitory(_repoContext);
                }
                return _z;
            }
        }
        public RepositoryWrapper(InternetstoreContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public async Task Save()
        {
            await _repoContext.SaveChangesAsync();
        }
    }
}
