using System;
using System.Collections.Generic;
using System.Text;

namespace Drink.Models
{
    public class Retorno
    {
        public int Id { get; set; }
        public string? Ingrediente { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime Data { get; set; }
    }
}
