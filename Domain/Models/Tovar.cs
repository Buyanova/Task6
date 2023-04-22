using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Tovar
    {
        public Tovar()
        {
            Corzinas = new HashSet<Corzina>();
        }

        public int IdTovara { get; set; }
        public string Name { get; set; } = null!;
        public int IdKategorii { get; set; }
        public int Kolichestvo { get; set; }
        public double Price { get; set; }
        public byte[] Image { get; set; } = null!;
        public string OpisanieTovara { get; set; } = null!;

        public virtual HaracterysticaTovarov IdKategoriiNavigation { get; set; } = null!;
        public virtual ICollection<Corzina> Corzinas { get; set; }
    }
}
