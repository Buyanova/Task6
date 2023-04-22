namespace BackendApi.Contracts.Haracterystica
{
    public class GetHaracterysticaResponse
    {
        public int IdKategorii { get; set; }
        public string NameKategorii { get; set; } = null!;
        public string Proizvoditel { get; set; } = null!;
        public string StranaProizvoditelya { get; set; } = null!;
        public string Brend { get; set; } = null!;
        public string Material { get; set; } = null!;
        public string Rasmer { get; set; } = null!;
    }
}
