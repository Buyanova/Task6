using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Domain.Interfaces
{
    public interface IRepositoryWrapper
    {
        IUserRepository Pokupatel { get; }
        IHaracterysticaRepisitory Haracterystica { get; }
        ITovarRepisitory Tovar { get; }
        ICorzinaRepisitory Corzina { get; }

        IZakazRepisitory Zakaz { get; }

        Task Save();
    }
}
