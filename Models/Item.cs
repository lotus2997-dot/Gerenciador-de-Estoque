using System;

namespace Drink.Models
{
    //Classe que representa um item do sistema,
    public class Item                       
    {
        //ela basicamente guarda as informações do item, como nome, categoria, etc
        //get = pega/lê o valor - set = define/atribui o valor
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
        public DateTime? UltimaAtualizacao { get; set; }
        public bool Ativo { get; set; } = true;
        public string Status
        {
            get
            {
                if (!Ativo)
                {
                    return "Inativo";
                }
                if (Validade.HasValue && Validade.Value < DateTime.Today)
                {
                    return "Vencido";
                }
                if (QuantidadeAtual <= 0)
                {
                    return "Sem estoque";
                }
                if (QuantidadeAtual <= QuantidadeMinima)
                {
                    return "Abaixo do mínimo";
                }
                //"Validade.HasValue" verifica se o item tem uma data de validade colocada, ou seeja, se ela não esta vazia
                //"Validade.Value" pega a validade colocada
                //"DateTime.Today.AddDays(7)" pega a data de hoje e adiciona 7 dias pra ver se ele está perto do vencimento
                if (Validade.HasValue && Validade.Value <= DateTime.Today.AddDays(7))
                {
                    return "Vencendo";
                }

                return "Normal";
            }
        }
    }
}