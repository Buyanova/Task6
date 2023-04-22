using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Corzina
    {
        public int IdZakaz { get; set; }
        public int IdTovara { get; set; }
        public double Price { get; set; }
        public int Kolichestvo { get; set; }
        public int Discount { get; set; }
        public string StatusTovara { get; set; } = null!;

        public virtual Tovar IdTovaraNavigation { get; set; } = null!;
    }
}
