namespace PROVAGUI
{
    partial class CadastroProdutosForm
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
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            txtDescricao = new TextBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            lstProdutos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(69, 88);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(69, 141);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(71, 194);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(125, 27);
            txtPreco.TabIndex = 2;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(69, 251);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(125, 27);
            txtDescricao.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(71, 284);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(71, 319);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(71, 354);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lstProdutos
            // 
            lstProdutos.FormattingEnabled = true;
            lstProdutos.Location = new Point(342, 69);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(280, 284);
            lstProdutos.TabIndex = 7;
            lstProdutos.SelectedIndexChanged += lstProdutos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 65);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 8;
            label1.Text = "CODIGO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 118);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 9;
            label2.Text = "NOME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 171);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 10;
            label3.Text = "PREÇO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 228);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 11;
            label4.Text = "DESCRIÇAO";
            // 
            // CadastroProdutosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstProdutos);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(txtDescricao);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Name = "CadastroProdutosForm";
            Text = "CadastroProdutosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtPreco;
        private TextBox txtDescricao;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnLimpar;
        private ListBox lstProdutos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}