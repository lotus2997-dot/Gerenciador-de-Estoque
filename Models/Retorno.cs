using System;

namespace Drink.Models
{
    public class Retorno
    {
        public int Id { get; set; }
        public int EventoId { get; set; }
        public int ItemEventoId { get; set; }
        public string? NomeEvento { get; set; }
        public string? NomeItem { get; set; }
        public decimal QuantidadeRetornada { get; set; }
        public bool ItemAdicionadoAoEstoque { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public string? Observacao { get; set; }
        public string? StatusFinal { get; set; }
    }
}
