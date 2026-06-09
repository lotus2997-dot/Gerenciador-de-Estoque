using System;
using System.Text.Json.Serialization;

namespace Drink.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public decimal QuantidadeAtual { get; set; }
        public string? Unidade { get; set; }
        public DateTime? Validade { get; set; }
        public decimal QuantidadeMinima { get; set; }
        public string? Fornecedor { get; set; }
        public string? Observacao { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime? UltimaAtualizacao { get; set; } = DateTime.Now;
        public bool Ativo { get; set; } = true;

        [JsonIgnore]
        public string Status
        {
            get
            {
                if (!Ativo)
                    return "Inativo";

                // Validade vem antes da quantidade: um item pode estar vencido E sem estoque
                if (Validade.HasValue && Validade.Value < DateTime.Today)
                    return "Vencido";

                if (Validade.HasValue && Validade.Value <= DateTime.Today.AddDays(7))
                    return "Vencendo";

                if (QuantidadeAtual <= 0)
                    return "Sem estoque";

                if (QuantidadeAtual <= QuantidadeMinima)
                    return "Abaixo do mínimo";

                return "Normal";
            }
        }
    }
}
