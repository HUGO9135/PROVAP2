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
    }
}
