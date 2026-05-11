using System;
using System.Collections.Generic;


namespace Drink.Models
{
    //Classe que representa um evento.
    //Ela guarda as informações principais do evento e também a lista de itens que foram separados para esse evento.
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public DateTime Data { get; set; }   //data do evento
        public string Local { get; set; } = "";   //local do evento
        public string Responsavel { get; set; } = "";   //responsável do evento
        public string Status { get; set; } = "Em Separação";    //status do evento, se os itens já foram separados ou não
        public List<ItemEvento> Itens { get; set; } = new List<ItemEvento>(); //essa linha cria uma lista de itens do evento (que são
                                                                              //os itens seprados para o evento) dentro da classa evento
    }
}
