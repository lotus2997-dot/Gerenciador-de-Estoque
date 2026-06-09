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
            Path.GetDirectoryName(Environment.ProcessPath
                ?? AppContext.BaseDirectory) ?? AppContext.BaseDirectory,
            "dados");

        private static readonly string _arquivoEstoque  = Path.Combine(_pasta, "estoque.json");

        private static readonly string _arquivoEventos  = Path.Combine(_pasta, "eventos.json");

        private static readonly string _arquivoRetornos = Path.Combine(_pasta, "retornos.json");

        private static readonly string _arquivoCatalogos = Path.Combine(_pasta, "catalogos.json");

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

                File.WriteAllText(_arquivoRetornos,
                    JsonSerializer.Serialize(DadosTemporarios.Retornos, _opcoes));

                var catalogos = new
                {
                    Categorias = CatalogosSistema.Categorias,
                    Unidades    = CatalogosSistema.Unidades
                };
                File.WriteAllText(_arquivoCatalogos,
                    JsonSerializer.Serialize(catalogos, _opcoes));
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
                        foreach (var ev in eventos)
                            foreach (var ie in ev.Itens)
                                ie.Item = DadosTemporarios.Itens
                                    .FirstOrDefault(i => i.Id == ie.ItemId);

                        DadosTemporarios.Eventos = eventos;
                    }
                }

                if (File.Exists(_arquivoRetornos))
                {
                    var retornos = JsonSerializer.Deserialize<List<Retorno>>(
                        File.ReadAllText(_arquivoRetornos), _opcoes);
                    if (retornos != null)
                        DadosTemporarios.Retornos = retornos;
                }

                if (File.Exists(_arquivoCatalogos))
                {
                    using var doc = JsonDocument.Parse(File.ReadAllText(_arquivoCatalogos));
                    var root = doc.RootElement;

                    if (root.TryGetProperty("Categorias", out var cats))
                    {
                        CatalogosSistema.Categorias.Clear();
                        foreach (var c in cats.EnumerateArray())
                        {
                            var val = c.GetString();
                            if (val != null && !CatalogosSistema.Categorias.Contains(val))
                                CatalogosSistema.Categorias.Add(val);
                        }
                    }

                    if (root.TryGetProperty("Unidades", out var units))
                    {
                        CatalogosSistema.Unidades.Clear();
                        foreach (var u in units.EnumerateArray())
                        {
                            var val = u.GetString();
                            if (val != null && !CatalogosSistema.Unidades.Contains(val))
                                CatalogosSistema.Unidades.Add(val);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao carregar dados:\n{ex.Message}\n\nO programa iniciará com dados vazios.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
