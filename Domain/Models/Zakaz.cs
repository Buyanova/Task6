using System.Collections.Generic;

namespace Domain.Models
{
    public class Zakaz
    {
        public int IdZakaz { get; set; }
        public int IdPokupatel { get; set; }
        public DateTime DateZakaz { get; set; }
        public int SrokSborki { get; set; }
        public string SposobDostavci { get; set; } = null!;
        public string StatusDostavci { get; set; } = null!;

        public virtual Pokupatel IdPokupatelNavigation { get; set; } = null!;
        public virtual Corzina IdZakazNavigation { get; set; } = null!;
    }
}
