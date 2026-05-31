using System.Collections.Generic;
using Drink.Models;

namespace Drink.Dados 
{
    // classe para criar dados temporários, somente enquanto o programa estiver rodando, até a chegada do banco
    public static class DadosTemporarios 
    {
        //cria um lista de itens do tipo "Item" (que são os itens que estão no estoque) nos dados temporarios
        public static List<Item> Itens { get; set; } = new List<Item>(); 
        //cria um lista de evetos do tipo "Evento" (que são os eventos que estão sendo organizados) nos dados temporarios
        public static List<Evento> Eventos { get; set; } = new List<Evento>(); 
    }
}