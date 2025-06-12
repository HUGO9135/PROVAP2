namespace PROVAGUI
{
    partial class LoginForm
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
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(340, 229);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(120, 29);
            btnEntrar.TabIndex = 9;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(340, 196);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(120, 27);
            txtSenha.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(340, 143);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(120, 27);
            txtUsuario.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 173);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 6;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 120);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 5;
            label1.Text = "Usuario:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
    }
}