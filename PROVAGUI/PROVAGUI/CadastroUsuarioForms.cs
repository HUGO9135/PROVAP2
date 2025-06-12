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
    public partial class CadastroUsuarioForms : Form
    {
        private List<Usuario> usuarios;

        public CadastroUsuarioForms()

        {
            InitializeComponent();
            CarregarUsuarios();
        }
        private void CarregarUsuarios()
        {
            usuarios = new List<Usuario>();

            string arquivo = "usuarios.csv";
            if (!File.Exists(arquivo))
            {
                File.WriteAllText(arquivo, "usuario;senha\nADMIN;123\n");
            }

            var linhas = File.ReadAllLines(arquivo);
            for (int i = 1; i < linhas.Length; i++)
            {
                var dados = linhas[i].Split(';');
                if (dados.Length == 2)
                {
                    usuarios.Add(new Usuario { Nome = dados[0], Senha = dados[1] });
                }
            }

            AtualizarLista();
        }

        private void AtualizarLista()
        {
            lstUsuarios.Items.Clear();
            foreach (var u in usuarios)
            {
                lstUsuarios.Items.Add(u.Nome);
            }
        }
    }
}
