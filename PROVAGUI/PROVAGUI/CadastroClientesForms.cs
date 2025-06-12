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
    public partial class CadastroClientesForms : Form
    {
        private const string caminhoArquivo = "clientes.csv";

        public CadastroClientesForms()
        {
            InitializeComponent();
            VerificarArquivoClientes();
            CarregarClientes();

        }
        private void VerificarArquivoClientes()
        {
            if (!File.Exists(caminhoArquivo))
            {
                File.WriteAllText(caminhoArquivo, "Nome;CPF;Email;CEP;Logradouro;Numero;Bairro;Cidade;Estado;Telefone;WhatsApp\n");
            }
        }

        private void CarregarClientes()
        {
            lstClientes.Items.Clear();
            var linhas = File.ReadAllLines(caminhoArquivo).Skip(1);

            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                if (dados.Length >= 11)
                {
                    lstClientes.Items.Add($"{dados[1]} - {dados[0]}"); // CPF - Nome
                }
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string linha = $"{txtNome.Text};{txtCPF.Text};{txtEmail.Text};{txtCEP.Text};{txtLogradouro.Text};{txtNumero.Text};{txtBairro.Text};{txtCidade.Text};{txtEstado.Text};{txtTelefone.Text};{txtWhatsApp.Text}";

            var linhas = File.ReadAllLines(caminhoArquivo).ToList();

            // Verifica se já existe esse CPF
            int index = linhas.FindIndex(l => l.StartsWith(";" + txtCPF.Text + ";") || l.Contains(";" + txtCPF.Text + ";"));
            if (index > 0)
            {
                linhas[index] = linha;
            }
            else
            {
                linhas.Add(linha);
            }

            File.WriteAllLines(caminhoArquivo, linhas);
            MessageBox.Show("Cliente salvo com sucesso!");
            CarregarClientes();
        }
    }
}
