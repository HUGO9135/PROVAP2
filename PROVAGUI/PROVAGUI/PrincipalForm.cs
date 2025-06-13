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
    public partial class PrincipalForm : Form
    {
        private string usuarioLogado;

        public PrincipalForm(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            this.Text = $"Principal - Usuário: {usuarioLogado}";
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            CadastroUsuarioForms cadastroForm = new CadastroUsuarioForms();
            cadastroForm.Show();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            CadastroClientesForms cadastroClientesForm = new CadastroClientesForms();
            cadastroClientesForm.Show();
        }

        private void btnCadastroProdutos_Click(object sender, EventArgs e)
        {
            CadastroProdutosForm cadastroProdutosForm = new CadastroProdutosForm();
            cadastroProdutosForm.Show();
        }

        private void btnCadastroPedidos_Click(object sender, EventArgs e)
        {
            CadastroPedidosForm cadastroPedidosForm = new CadastroPedidosForm();
            cadastroPedidosForm.Show();
        }
    }
}
