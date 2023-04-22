using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Pokupatel
    {
        public int IdPokupatel { get; set; }
        public string Fio { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Adres { get; set; } = null!;
    }
}
