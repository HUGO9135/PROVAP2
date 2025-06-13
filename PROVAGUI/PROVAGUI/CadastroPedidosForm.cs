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
    public partial class CadastroPedidosForm : Form
    {
        public CadastroPedidosForm()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text.Trim();
            string arquivoClientes = "clientes.csv";

            if (!File.Exists(arquivoClientes))
            {
                MessageBox.Show("Arquivo de clientes não encontrado.");
                return;
            }

            var linhas = File.ReadAllLines(arquivoClientes).Skip(1);
            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                if (dados.Length > 1 && dados[1] == cpf)
                {
                    lblNomeCliente.Text = dados[0];
                    return;
                }
            }

            lblNomeCliente.Text = "Cliente não encontrado";
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoPedido.Text.Trim();
            int quantidade;

            if (!int.TryParse(txtQuantidade.Text.Trim(), out quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }

            string arquivoProdutos = "produtos.csv";
            if (!File.Exists(arquivoProdutos))
            {
                MessageBox.Show("Arquivo de produtos não encontrado.");
                return;
            }

            var linhas = File.ReadAllLines(arquivoProdutos).Skip(1);
            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                if (dados.Length >= 3 && dados[0] == codigo)
                {
                    string nome = dados[1];
                    if (!decimal.TryParse(dados[2], out decimal preco))
                    {
                        MessageBox.Show("Erro ao converter preço.");
                        return;
                    }

                    decimal subtotal = preco * quantidade;

                    ListViewItem item = new ListViewItem(new[] {
                codigo, nome, preco.ToString("F2"), quantidade.ToString(), subtotal.ToString("F2")
            });

                    lstProdutosPedido.Items.Add(item);
                    AtualizarTotalPedido();
                    return;
                }
            }

            MessageBox.Show("Produto não encontrado.");
        }

        private void AtualizarTotalPedido()
        {
            decimal total = 0;
            foreach (ListViewItem item in lstProdutosPedido.Items)
            {
                if (decimal.TryParse(item.SubItems[4].Text, out decimal subtotal))
                {
                    total += subtotal;
                }
            }
            lblTotalPedido.Text = "Total: R$ " + total.ToString("F2");
        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            if (lstProdutosPedido.Items.Count == 0)
            {
                MessageBox.Show("Adicione ao menos um produto ao pedido.");
                return;
            }

            string cpf = txtCPF.Text.Trim();
            if (cpf.Length < 11)
            {
                MessageBox.Show("CPF inválido.");
                return;
            }

            string caminho = "pedidos.csv";

            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, "ID;Data;CPFCliente;Produtos;Total\n");
            }

            var linhas = File.ReadAllLines(caminho).ToList();
            int novoId = linhas.Count; 

            string data = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string produtos = string.Join(",", lstProdutosPedido.Items
                .Cast<ListViewItem>()
                .Select(item => $"{item.SubItems[0].Text}x{item.SubItems[3].Text}"));

            decimal total = 0;
            foreach (ListViewItem item in lstProdutosPedido.Items)
            {
                if (decimal.TryParse(item.SubItems[4].Text, out decimal subtotal))
                {
                    total += subtotal;
                }
            }

            string linhaPedido = $"{novoId};{data};{cpf};{produtos};{total:F2}";
            File.AppendAllText(caminho, linhaPedido + "\n");

            MessageBox.Show("Pedido finalizado com sucesso!");

            // Limpa campos
            txtCPF.Clear();
            txtCodigoPedido.Clear();
            txtQuantidade.Clear();
            lstProdutosPedido.Items.Clear();
            lblTotalPedido.Text = "Total: R$ 0,00";
        }
    }
}
