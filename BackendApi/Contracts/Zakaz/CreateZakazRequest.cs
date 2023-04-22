using Domain.Models;

namespace BackendApi.Contracts.Zakaz
{
    public class CreateZakazRequest
    {
        public DateTime DateZakaz { get; set; }
        public int SrokSborki { get; set; }
        public string SposobDostavci { get; set; } = null!;
        public string StatusDostavci { get; set; } = null!;

    }
}
