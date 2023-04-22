namespace BackendApi.Contracts.Tovar
{
    public class GetTovarResponse
    {
        public int IdTovara { get; set; }
        public string Name { get; set; } = null!;
        public int IdKategorii { get; set; }
        public int Kolichestvo { get; set; }
        public double Price { get; set; }
        public byte[] Image { get; set; } = null!;
        public string OpisanieTovara { get; set; } = null!;
    }
}
