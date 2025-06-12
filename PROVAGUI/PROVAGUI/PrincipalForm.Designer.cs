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
            SuspendLayout();
            // 
            // btnCadastroUsuario
            // 
            btnCadastroUsuario.Location = new Point(383, 162);
            btnCadastroUsuario.Name = "btnCadastroUsuario";
            btnCadastroUsuario.Size = new Size(104, 29);
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
            // PrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}