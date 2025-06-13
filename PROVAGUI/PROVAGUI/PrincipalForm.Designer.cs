namespace PROVAGUI
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastroUsuario = new Button();
            btnCadastroCliente = new Button();
            btnCadastroProdutos = new Button();
            btnCadastroPedidos = new Button();
            SuspendLayout();
            // 
            // btnCadastroUsuario
            // 
            btnCadastroUsuario.Location = new Point(367, 162);
            btnCadastroUsuario.Name = "btnCadastroUsuario";
            btnCadastroUsuario.Size = new Size(240, 94);
            btnCadastroUsuario.TabIndex = 0;
            btnCadastroUsuario.Text = "USUARIO";
            btnCadastroUsuario.UseVisualStyleBackColor = true;
            btnCadastroUsuario.Click += btnCadastroUsuario_Click;
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.Location = new Point(121, 162);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(240, 94);
            btnCadastroCliente.TabIndex = 1;
            btnCadastroCliente.Text = "CADASTRO CLIENTES";
            btnCadastroCliente.UseVisualStyleBackColor = true;
            btnCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // btnCadastroProdutos
            // 
            btnCadastroProdutos.Location = new Point(121, 262);
            btnCadastroProdutos.Name = "btnCadastroProdutos";
            btnCadastroProdutos.Size = new Size(240, 94);
            btnCadastroProdutos.TabIndex = 2;
            btnCadastroProdutos.Text = "CADASTRO PRODUTOS";
            btnCadastroProdutos.UseVisualStyleBackColor = true;
            btnCadastroProdutos.Click += btnCadastroProdutos_Click;
            // 
            // btnCadastroPedidos
            // 
            btnCadastroPedidos.Location = new Point(367, 262);
            btnCadastroPedidos.Name = "btnCadastroPedidos";
            btnCadastroPedidos.Size = new Size(240, 94);
            btnCadastroPedidos.TabIndex = 3;
            btnCadastroPedidos.Text = "CADASTRO PEDIDOS";
            btnCadastroPedidos.UseVisualStyleBackColor = true;
            btnCadastroPedidos.Click += btnCadastroPedidos_Click;
            // 
            // PrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastroPedidos);
            Controls.Add(btnCadastroProdutos);
            Controls.Add(btnCadastroCliente);
            Controls.Add(btnCadastroUsuario);
            Name = "PrincipalForm";
            Text = "PrincipalForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastroUsuario;
        private Button button1;
        private Button btnCadastroCliente;
        private Button btnCadastroProdutos;
        private Button btnCadastroPedidos;
    }
}