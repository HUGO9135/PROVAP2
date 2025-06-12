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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ArquivoUsuarios();
        }
        private void ArquivoUsuarios()
        {
            string arquivo = "usuarios.csv";
            if (!File.Exists(arquivo))
            {
                File.WriteAllText(arquivo, "usuario;senha\nADMIN;123\n");
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            var usuarios = CarregarUsuarios();

            bool logado = false;

            foreach (var u in usuarios)
            {
                if (u.Nome.Equals(usuario, StringComparison.OrdinalIgnoreCase) && u.Senha == senha)
                {
                    logado = true;
                    break;
                }
            }

            if (logado)
            {
                MessageBox.Show("Login efetuado com sucesso!");
                this.Hide();
                var principal = new PrincipalForm(usuario);
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }
        private List<Usuario> CarregarUsuarios()
        {
            var lista = new List<Usuario>();
            string arquivo = "usuarios.csv";

            var linhas = File.ReadAllLines(arquivo);
            for (int i = 1; i < linhas.Length; i++) // pular header
            {
                var dados = linhas[i].Split(';');
                if (dados.Length == 2)
                {
                    lista.Add(new Usuario { Nome = dados[0], Senha = dados[1] });
                }
            }
            return lista;
        }
    }

    public class Usuario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
    
