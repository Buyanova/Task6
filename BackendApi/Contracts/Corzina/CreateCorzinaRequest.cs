namespace BackendApi.Contracts.Corzina
{
    public class CreateCorzinaRequest
    {
        public double Price { get; set; }
        public int Kolichestvo { get; set; }
        public int Discount { get; set; }
        public string StatusTovara { get; set; } = null!;

    }
}
