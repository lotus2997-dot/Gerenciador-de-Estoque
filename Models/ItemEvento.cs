using System;
using System.Collections.Generic;
using System.Text;

namespace Drink.Models
{
    public class ItemEvento            //Classe que representa um ingrediente separado para um evento.                                                                                                           //quantidade, unidade, data do evento e observações específicas para o evento.
    {
        public int Id { get; set; } // id do item do evento
        public Item Item { get; set; } = new Item(); // item que veio do estoque
        public decimal QuantidadeSeparada { get; set; } // quantidade separada para o evento
        public decimal QuantidadeRetornada { get; set; } // quantidade que voltou depois do evento
        public string Status { get; set; } = "Pendente"; //// status do item no evento: pendente, separado, retornado etc.
        public string? Observacao { get; set; }  // observação específica desse item no evento
        public bool VeioDoEstoque { get; set; } = true; //verifica se o item veio do estoque ou se é um item fora do estoque
        public decimal QuantidadeConsumida // calcula quanto foi usado ou consumido no evento
        {
            get
            {
                return QuantidadeSeparada - QuantidadeRetornada;
            }
        }

    }

}
