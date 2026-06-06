using System;
using System.Collections.Generic;
using Drink.Models;

namespace Drink.Dados
{
    public static class DadosTemporarios
    {
        public static List<Item> Itens { get; set; } = new List<Item>();

        public static List<Evento> Eventos { get; set; } = new List<Evento>();

        public static List<Retorno> Retornos { get; set; } = new List<Retorno>();
    }
}