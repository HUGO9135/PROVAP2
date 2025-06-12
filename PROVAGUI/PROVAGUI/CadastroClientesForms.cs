using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;

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
            int index = linhas.FindIndex(l => l.Split(';')[1] == txtCPF.Text);
            if (index > 0)
            {
                linhas[index] = linha;
            }
            else
            {
                linhas.Add(linha);
            }

            linhas.Insert(0, "Nome;CPF;Email;CEP;Logradouro;Numero;Bairro;Cidade;Estado;Telefone;WhatsApp");
            File.WriteAllLines(caminhoArquivo, linhas);
            MessageBox.Show("Cliente salvo com sucesso!");
            CarregarClientes();
        }

        private async Task BuscarEnderecoPorCEP(string cep)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var endereco = System.Text.Json.JsonSerializer.Deserialize<ViaCepEndereco>(json);

                        if (endereco != null && endereco.cep != null)
                        {
                            txtLogradouro.Text = endereco.logradouro;
                            txtBairro.Text = endereco.bairro;
                            txtCidade.Text = endereco.localidade;
                            txtEstado.Text = endereco.uf;
                        }
                        else
                        {
                            MessageBox.Show("CEP não encontrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar CEP.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private async void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Replace("-", "").Trim();
            await BuscarEnderecoPorCEP(cep);
        }
    }
    public class ViaCepEndereco
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
    }

}
