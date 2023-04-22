using Domain.Models;

namespace BackendApi.Contracts.Zakaz
{
    public class GetZakazResponse
    {
        public int IdZakaz { get; set; }
        public int IdPokupatel { get; set; }
        public DateTime DateZakaz { get; set; }
        public int SrokSborki { get; set; }
        public string SposobDostavci { get; set; } = null!;
        public string StatusDostavci { get; set; } = null!;

    }
}
