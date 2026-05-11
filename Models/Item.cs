using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Drink.Models
{
    public class Item                           //Classe que representa um item do sistema,
    {                                                 //ela basicamente guarda as informações do item, como nome, categoria, etc
        public int Id { get; set; }                  //get = pega/lê o valor - set = define/atribui o valor
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
        public string Status
        {
            get
            {
                
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