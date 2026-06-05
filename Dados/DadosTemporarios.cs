using System;
using System.Collections.Generic;
using Drink.Models;

namespace Drink.Dados
{
    public static class DadosTemporarios
    {
        public static List<Item> Itens { get; set; } = new List<Item>
        {
            new Item { Id = 1, Nome = "Vodka Absolut", Categoria = "Destilado", QuantidadeAtual = 10, Unidade = "Garrafa", QuantidadeMinima = 2 },
            new Item { Id = 2, Nome = "Suco de Limão", Categoria = "Suco", QuantidadeAtual = 5, Unidade = "Litro", QuantidadeMinima = 1 },
            new Item { Id = 3, Nome = "Refrigerante Tônica", Categoria = "Bebida", QuantidadeAtual = 20, Unidade = "Lata", QuantidadeMinima = 5 },
            new Item { Id = 4, Nome = "Rum Bacardi", Categoria = "Destilado", QuantidadeAtual = 8, Unidade = "Garrafa", QuantidadeMinima = 2 },
        };

        public static List<Evento> Eventos { get; set; } = new List<Evento>
        {
            new Evento
            {
                Id = 1,
                Nome = "Festa de Aniversário",
                Data = DateTime.Today.AddDays(-1),
                Local = "Salão Principal",
                Responsavel = "João Silva",
                Status = "Separado",
                Itens = new List<ItemEvento>
                {
                    new ItemEvento
                    {
                        Id = 1,
                        Item = Itens[0],
                        QuantidadeSeparada = 3,
                        QuantidadeRetornada = 0,
                        Status = "Separado",
                        VeioDoEstoque = true
                    },
                    new ItemEvento
                    {
                        Id = 2,
                        Item = Itens[2],
                        QuantidadeSeparada = 12,
                        QuantidadeRetornada = 0,
                        Status = "Separado",
                        VeioDoEstoque = true
                    },
                }
            },
            new Evento
            {
                Id = 2,
                Nome = "Evento Corporativo",
                Data = DateTime.Today,
                Local = "Auditório",
                Responsavel = "Maria Souza",
                Status = "Separado",
                Itens = new List<ItemEvento>
                {
                    new ItemEvento
                    {
                        Id = 3,
                        Item = Itens[1],
                        QuantidadeSeparada = 2,
                        QuantidadeRetornada = 0,
                        Status = "Separado",
                        VeioDoEstoque = true
                    },
                    new ItemEvento
                    {
                        Id = 4,
                        Item = Itens[3],
                        QuantidadeSeparada = 4,
                        QuantidadeRetornada = 0,
                        Status = "Separado",
                        VeioDoEstoque = true
                    },
                }
            }
        };

        public static List<Retorno> Retornos { get; set; } = new List<Retorno>();
    }
}