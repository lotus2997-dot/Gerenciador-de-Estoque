using System;
using System.Collections.Generic;
using System.Text;

namespace Drink.Models
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Unidade { get; set; }
        public decimal QuantidadeAtual { get; set; }
        public decimal QuantidadeMinima { get; set; }
        public DateTime Validade { get; set; }
    }
}