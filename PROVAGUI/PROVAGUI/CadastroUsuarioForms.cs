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
        private void SalvarUsuarios()
        {
            string arquivo = "usuarios.csv";

            var linhas = new List<string> { "usuario;senha" };
            linhas.AddRange(usuarios.Select(u => $"{u.Nome};{u.Senha}"));

            File.WriteAllLines(arquivo, linhas);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha usuário e senha.");
                return;
            }

            if (nome.Equals("ADMIN", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Não é permitido alterar o usuário ADMIN.");
                return;
            }

            var usuarioExistente = usuarios.FirstOrDefault(u => u.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (usuarioExistente != null)
            {

                usuarioExistente.Senha = senha;
            }
            else
            {

                usuarios.Add(new Usuario { Nome = nome, Senha = senha });
            }

            SalvarUsuarios();
            AtualizarLista();
            LimparCampos();
            MessageBox.Show("Usuário salvo com sucesso!");
        }

        private void LimparCampos()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Selecione um usuário para excluir.");
                return;
            }
            string nomeSelecionado = lstUsuarios.SelectedItem.ToString();

            if (nomeSelecionado.Equals("ADMIN", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Não é permitido excluir o usuário ADMIN.");
                return;
            }

            var usuarioExcluir = usuarios.FirstOrDefault(u => u.Nome.Equals(nomeSelecionado, StringComparison.OrdinalIgnoreCase));
            if (usuarioExcluir != null)
            {
                usuarios.Remove(usuarioExcluir);
                SalvarUsuarios();
                AtualizarLista();
                LimparCampos();
                MessageBox.Show("Usuário excluído com sucesso!");
            }
        }
    }
}
