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
        public string NomeExibicao =>
        $"{Item?.Nome ?? "Item externo"} — {QuantidadeSeparada} {Item?.Unidade}";

        // novo campo: confirma que o usuário analisou esse item no retorno
        public bool ConferidoRetorno { get; set; } = false;


        public decimal QuantidadeConsumida
        {
            get
            {
                decimal consumida = QuantidadeSeparada - QuantidadeRetornada;
                return consumida < 0 ? 0 : consumida;
            }
        }
    }
}
