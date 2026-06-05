using System;
using System.Collections.Generic;

namespace Drink.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime Data { get; set; }

        public string Local { get; set; } = string.Empty;
        public string Responsavel { get; set; } = string.Empty;
        public string ContatoResponsavel { get; set; } = string.Empty;

        public DateTime HoraInicio { get; set; }
        public DateTime HoraFim { get; set; }

        public int QuantidadePessoas { get; set; }
        public string Status { get; set; } = "Em montagem";

        public List<ItemEvento> Itens { get; set; } = new List<ItemEvento>();
    }
}