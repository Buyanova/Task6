using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class TovarRepisitory : RepositoryBase<Tovar>, ITovarRepisitory
    {
        public TovarRepisitory(InternetstoreContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
