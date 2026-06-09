using Drink.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Drink.Dados

{
    public static class JsonHelper
    {
        private static readonly string _pasta = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "dados");

        private static readonly string _arquivoEstoque = Path.Combine(_pasta, "estoque.json");
        private static readonly string _arquivoEventos = Path.Combine(_pasta, "eventos.json");

        private static readonly JsonSerializerOptions _opcoes = new()
        {
            WriteIndented = true,
            ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles
        };



        public static void Salvar()
        {
            try
            {
                Directory.CreateDirectory(_pasta);

                File.WriteAllText(_arquivoEstoque,
                    JsonSerializer.Serialize(DadosTemporarios.Itens, _opcoes));

                File.WriteAllText(_arquivoEventos,
                    JsonSerializer.Serialize(DadosTemporarios.Eventos, _opcoes));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar dados:\n{ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Carregar()
        {
            try
            {
                Directory.CreateDirectory(_pasta);

                if (File.Exists(_arquivoEstoque))
                {
                    var itens = JsonSerializer.Deserialize<List<Item>>(
                        File.ReadAllText(_arquivoEstoque), _opcoes);
                    if (itens != null)
                        DadosTemporarios.Itens = itens;
                }

                if (File.Exists(_arquivoEventos))
                {
                    var eventos = JsonSerializer.Deserialize<List<Evento>>(
                        File.ReadAllText(_arquivoEventos), _opcoes);
                    if (eventos != null)
                    {
                        // Reconecta cada ItemEvento ao seu Item pelo Id
                        foreach (var ev in eventos)
                            foreach (var ie in ev.Itens)
                                ie.Item = DadosTemporarios.Itens
                                    .FirstOrDefault(i => i.Id == ie.ItemId);

                        DadosTemporarios.Eventos = eventos;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados:\n{ex.Message}\n\nO programa iniciará com dados vazios.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
