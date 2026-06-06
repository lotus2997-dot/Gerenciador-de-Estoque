using System;

namespace Drink.Models
{
    public class ItemEvento
    {
        public int Id { get; set; }
        public Item Item { get; set; } = new Item();
        public decimal QuantidadeSeparada { get; set; }
        public decimal QuantidadeRetornada { get; set; }
        public string Status { get; set; } = "Pendente";
        public string? Observacao { get; set; }
        public bool VeioDoEstoque { get; set; } = true;
        public bool ConferidoRetorno { get; set; } = false;
        public string NomeExibicao =>
            $"{Item?.Nome ?? "Item externo"} — {QuantidadeSeparada} {Item?.Unidade}";
        public decimal QuantidadeConsumida => QuantidadeSeparada - QuantidadeRetornada;
    }

}
