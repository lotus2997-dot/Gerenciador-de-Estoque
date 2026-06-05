using System;
using System.Collections.Generic;

namespace Drink.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public DateTime Data { get; set; }
        public string Local { get; set; } = "";
        public string Responsavel { get; set; } = "";
        public string Status { get; set; } = "Em montagem";
        public List<ItemEvento> Itens { get; set; } = new List<ItemEvento>();
    }
}