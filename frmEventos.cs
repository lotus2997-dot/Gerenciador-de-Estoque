using Drink.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;


namespace Drink
{
    public partial class frmEventos : Form
    {
        private Evento eventoAtual; // variável para armazenar o evento que esta aberto na tela, pra poder usar ele em outros métodos

        private List<Item> itensEstoque = new List<Item>(); // cria uma lista de itens do estoque, pra poder usar ela em outros métodos
        public frmEventos()
        {
            InitializeComponent();

            ConfigurarAparenciaTabela();
            CarregarDadosExemplo();
        }

        private void ConfigurarAparenciaTabela()
        {
            // Define a fonte geral da tabela.
            dgvItensEvento.Font = new Font("Segoe UI", 10);

            // Define a altura das linhas.
            dgvItensEvento.RowTemplate.Height = 32;

            // Remove a borda 3D padrão para deixar mais limpo.
            dgvItensEvento.BorderStyle = BorderStyle.FixedSingle;

            // Faz a linha inteira ser selecionada.
            dgvItensEvento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Impede edição direta na tabela.
            dgvItensEvento.ReadOnly = true;

            // Impede o usuário de adicionar linhas manualmente.
            dgvItensEvento.AllowUserToAddRows = false;

            // Remove a coluna lateral cinza.
            dgvItensEvento.RowHeadersVisible = false;

            // Ajusta as colunas automaticamente.
            dgvItensEvento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cores do cabeçalho.
            dgvItensEvento.EnableHeadersVisualStyles = false;
            dgvItensEvento.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 59, 102);
            dgvItensEvento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvItensEvento.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvItensEvento.ColumnHeadersHeight = 35;

            // Cor de seleção.
            dgvItensEvento.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 230, 250);
            dgvItensEvento.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        private void CarregarDadosExemplo()
        {
            dgvItensEvento.Rows.Clear();


            ColorirStatus();
        }

        // Este método percorre todas as linhas do DataGridView de itens do evento.
        // Para cada linha, ele lê o valor da coluna "colStatus".
        // Dependendo do status encontrado, ele muda a cor do texto dessa célula.
        //
        private void ColorirStatus()
        {
            foreach (DataGridViewRow row in dgvItensEvento.Rows)
            {
                string status = row.Cells["colStatus"].Value?.ToString() ?? "";

                if (status == "Separado")
                {
                    row.Cells["colStatus"].Style.ForeColor = Color.Green;
                }
                else if (status == "Pendente")
                {
                    row.Cells["colStatus"].Style.ForeColor = Color.DarkOrange;
                }
                else if (status == "Disponível")
                {
                    row.Cells["colStatus"].Style.ForeColor = Color.Blue;
                }
                else if (status == "Retornado")
                {
                    row.Cells["colStatus"].Style.ForeColor = Color.Purple;
                }
            }
        }

        private void frmEventos_Load(object sender, EventArgs e) //método que executa quando a tela de eventos é aberta, ele carrega um evento exemplo para mostrar as informações do evento e os itens do evento
        {
            eventoAtual = new Evento //evento exemplo
            {
                Id = 1,
                Nome = "Nome do Evento",
                Data = new DateTime(2026, 04, 28),
                Local = "Local do Evento",
                Responsavel = "Administrador",
                Status = "Em Separação"
            };

            AtualizarTabelaItens();
        }
        private void AtualizarTabelaItens() //método para atualizar a tabela de itens do evento, ele pega os itens do evento atual e coloca eles na tabela
        {
            var dadosTabela = eventoAtual.Itens.Select(itemEvento => new //seleciona os itens do evento atual e transforma eles em um formato que a tabela consegue entender
            {
                ID = itemEvento.Id.ToString("000"), //formata o id do item para ter 3 digitos
                Nome = itemEvento.Item.Nome,
                Categoria = itemEvento.Item.Categoria,
                Qtd = itemEvento.QuantidadeSeparada,
                Unidade = itemEvento.Item.Unidade,
                Status = itemEvento.Status,
                Origem = itemEvento.VeioDoEstoque ? "Estoque" : "Externo" //verifica se o item veio do estoque ou se é um item externo e mostra na tabela
            }).ToList(); //transforma os itens selecionados em uma lista

            dgvItensEvento.DataSource = null;
            dgvItensEvento.DataSource = dadosTabela;
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            frmNovoItemEvento telaNovoItem = new frmNovoItemEvento(itensEstoque); //abre a tela do novo item

            if (telaNovoItem.ShowDialog() == DialogResult.OK) //verifica se o usuário clicou em adicionar na tela do novo item 
            {
                ItemEvento? novoItem = telaNovoItem.ItemCriado;//pega o item criado na tela do novo item

                if (novoItem == null)
                {
                    return;
                }

                if (eventoAtual.Itens.Any()) //verifica se tem algum item
                {
                    novoItem.Id = eventoAtual.Itens.Max(i => i.Id) + 1; //se tiver, adiciona +1 no id
                }
                else
                {
                    novoItem.Id = 1; //se não, coloca 1 no id
                }

                eventoAtual.Itens.Add(novoItem); //coloca o item criado na lista de itens do evento atual

                AtualizarTabelaItens(); //atualiza a tabela de itens do evento para mostrar o item que acabou de ser adicionado
            }
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (dgvItensEvento.CurrentRow == null) //verifica se o usuário selecionou alguma linha no dgv
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }

            string idTexto = dgvItensEvento.CurrentRow.Cells["ID"].Value.ToString(); //pega o valor da coluna id da linha selecionada e transforma e string

            int idItem = int.Parse(idTexto); //pega o valor transformado em string e transforma em int

            ItemEvento? itemSelecionado = eventoAtual.Itens.FirstOrDefault(i => i.Id == idItem); // // Usa o id selecionado no dgv para encontrar o item correspondente na lista do evento

            if (itemSelecionado == null)
            {
                MessageBox.Show("Item não encontrado.");
                return;
            }

            DialogResult resposta = MessageBox.Show(    // confirmaçao se o usuário realmente quer remover o item selecionado do evento
                "Deseja realmente remover este item do evento?",
                "Remover item",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.No)
            {
                return;
            }

            eventoAtual.Itens.Remove(itemSelecionado); //remove o item selecionado da lista de itens do evento

            AtualizarTabelaItens(); //atualiza a tabela
        }
    }
}