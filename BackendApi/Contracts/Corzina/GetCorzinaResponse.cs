namespace BackendApi.Contracts.Corzina
{
    public class GetCorzinaResponse
    {
        public int IdZakaz { get; set; }
        public int IdTovara { get; set; }
        public double Price { get; set; }
        public int Kolichestvo { get; set; }
        public int Discount { get; set; }
        public string StatusTovara { get; set; } = null!;
    }
}
