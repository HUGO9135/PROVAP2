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
    }
}
