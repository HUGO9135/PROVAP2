using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROVAGUI
{
    public partial class CadastroProdutosForm : Form
    {
        private const string caminhoArquivo = "produtos.csv";

        public CadastroProdutosForm()
        {
            InitializeComponent();
            CarregarProdutos();
            VerificarArquivo();


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string nome = txtNome.Text.Trim();
            string precoStr = txtPreco.Text.Trim();
            string descricao = txtDescricao.Text.Trim();

            if (!decimal.TryParse(precoStr, out decimal preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            var novaLinha = $"{codigo};{nome};{preco.ToString("F2")};{descricao}";

            var linhas = File.ReadAllLines(caminhoArquivo).ToList();
            int index = linhas.FindIndex(l => l.StartsWith(codigo + ";"));

            if (index > 0)
            {
                linhas[index] = novaLinha;
            }
            else
            {
                linhas.Add(novaLinha);
            }

            File.WriteAllLines(caminhoArquivo, linhas);
            MessageBox.Show("Produto salvo com sucesso!");
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            lstProdutos.Items.Clear();
            var linhas = File.ReadAllLines(caminhoArquivo).Skip(1);

            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                if (dados.Length >= 4)
                {
                    lstProdutos.Items.Add($"{dados[0]} - {dados[1]} - R$ {dados[2]}");
                }
            }
        }
        private void VerificarArquivo()
        {
            if (!File.Exists(caminhoArquivo))
            {
                File.WriteAllText(caminhoArquivo, "codigo;nome;preco;descricao\n");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstProdutos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            string itemSelecionado = lstProdutos.SelectedItem.ToString();
            string codigo = itemSelecionado.Split('-')[0].Trim();

            var linhas = File.ReadAllLines(caminhoArquivo).ToList();
            int index = linhas.FindIndex(l => l.StartsWith(codigo + ";"));

            if (index > 0)
            {
                linhas.RemoveAt(index);
                File.WriteAllLines(caminhoArquivo, linhas);
                MessageBox.Show("Produto excluído com sucesso!");
                CarregarProdutos();
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtPreco.Text = "";
            txtDescricao.Text = "";
            lstProdutos.ClearSelected();
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProdutos.SelectedItem == null) return;

            string itemSelecionado = lstProdutos.SelectedItem.ToString();
            string codigo = itemSelecionado.Split('-')[0].Trim();

            var linhas = File.ReadAllLines(caminhoArquivo).Skip(1);

            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                if (dados[0] == codigo)
                {
                    txtCodigo.Text = dados[0];
                    txtNome.Text = dados[1];
                    txtPreco.Text = dados[2];
                    txtDescricao.Text = dados[3];
                    break;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
