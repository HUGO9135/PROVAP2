namespace PROVAGUI
{
    partial class CadastroPedidosForm
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
            txtCodigoPedido = new TextBox();
            label1 = new Label();
            btnBuscarCliente = new Button();
            cmbProdutos = new ComboBox();
            lstProdutosPedido = new ListView();
            lblNomeCliente = new Label();
            lblTotalPedido = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCPF = new TextBox();
            txtQuantidade = new TextBox();
            btnSalvarPedido = new Button();
            btnAdicionarProduto = new Button();
            SuspendLayout();
            // 
            // txtCodigoPedido
            // 
            txtCodigoPedido.Location = new Point(118, 225);
            txtCodigoPedido.Name = "txtCodigoPedido";
            txtCodigoPedido.Size = new Size(122, 27);
            txtCodigoPedido.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 103);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 1;
            label1.Text = "CPF";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(193, 124);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(94, 29);
            btnBuscarCliente.TabIndex = 2;
            btnBuscarCliente.Text = "BUSCAR";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // cmbProdutos
            // 
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(118, 278);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(151, 28);
            cmbProdutos.TabIndex = 3;
            // 
            // lstProdutosPedido
            // 
            lstProdutosPedido.Location = new Point(350, 95);
            lstProdutosPedido.Name = "lstProdutosPedido";
            lstProdutosPedido.Size = new Size(251, 242);
            lstProdutosPedido.TabIndex = 4;
            lstProdutosPedido.UseCompatibleStateImageBehavior = false;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(65, 58);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(55, 20);
            lblNomeCliente.TabIndex = 5;
            lblNomeCliente.Text = "NOME:";
            // 
            // lblTotalPedido
            // 
            lblTotalPedido.AutoSize = true;
            lblTotalPedido.Location = new Point(350, 72);
            lblTotalPedido.Name = "lblTotalPedido";
            lblTotalPedido.Size = new Size(115, 20);
            lblTotalPedido.TabIndex = 6;
            lblTotalPedido.Text = "TOTAL PEDIDOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 309);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 7;
            label4.Text = "QUANTIDADE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 255);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 8;
            label5.Text = "CARREGAR PRODUTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 192);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 9;
            label6.Text = "CODIGO PEDIDO";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(65, 126);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(122, 27);
            txtCPF.TabIndex = 10;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(118, 332);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(122, 27);
            txtQuantidade.TabIndex = 11;
            // 
            // btnSalvarPedido
            // 
            btnSalvarPedido.Location = new Point(507, 343);
            btnSalvarPedido.Name = "btnSalvarPedido";
            btnSalvarPedido.Size = new Size(94, 29);
            btnSalvarPedido.TabIndex = 12;
            btnSalvarPedido.Text = "SALVAR";
            btnSalvarPedido.UseVisualStyleBackColor = true;
            btnSalvarPedido.Click += btnSalvarPedido_Click;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Location = new Point(118, 365);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(122, 29);
            btnAdicionarProduto.TabIndex = 13;
            btnAdicionarProduto.Text = "ADICIONAR";
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // CadastroPedidosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdicionarProduto);
            Controls.Add(btnSalvarPedido);
            Controls.Add(txtQuantidade);
            Controls.Add(txtCPF);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblTotalPedido);
            Controls.Add(lblNomeCliente);
            Controls.Add(lstProdutosPedido);
            Controls.Add(cmbProdutos);
            Controls.Add(btnBuscarCliente);
            Controls.Add(label1);
            Controls.Add(txtCodigoPedido);
            Name = "CadastroPedidosForm";
            Text = "CadastroPedidosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigoPedido;
        private Label label1;
        private Button btnBuscarCliente;
        private ComboBox cmbProdutos;
        private ListView lstProdutosPedido;
        private Label lblNomeCliente;
        private Label lblTotalPedido;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCPF;
        private TextBox txtQuantidade;
        private Button btnSalvarPedido;
        private Button btnAdicionarProduto;
    }
}