
using Drink.Models;
using System;
using System.Text.Json.Serialization;

namespace Drink.Models
{
    public class ItemEvento
    {
        public int Id { get; set; }
        public int ItemId { get; set; }

        [JsonIgnore]
        public Item? Item { get; set; }

        public decimal QuantidadeSeparada { get; set; }
        public decimal QuantidadeRetornada { get; set; }
        public string Status { get; set; } = "Pendente";
        public string? Observacao { get; set; }
        public bool VeioDoEstoque { get; set; } = true;
        public bool ConferidoRetorno { get; set; } = false;

        public decimal QuantidadeConsumida => QuantidadeSeparada - QuantidadeRetornada;
        public string NomeExibicao =>
            $"{Item?.Nome ?? "Item externo"} — {QuantidadeSeparada} {Item?.Unidade}";
    }
}
