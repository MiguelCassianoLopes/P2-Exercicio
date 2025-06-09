namespace P2_Exercicio
{
    partial class FormProdutos
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
            txtNomeProduto = new TextBox();
            textBox2 = new TextBox();
            txtDescricao = new TextBox();
            lbProduto = new Label();
            txtPrecoProduto = new Label();
            lbDescricao = new Label();
            btSalvar = new Button();
            btExcluir = new Button();
            lstProdutos = new ListBox();
            SuspendLayout();
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(120, 72);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(173, 23);
            txtNomeProduto.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 1;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(120, 130);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(173, 23);
            txtDescricao.TabIndex = 2;
            // 
            // lbProduto
            // 
            lbProduto.AutoSize = true;
            lbProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbProduto.Location = new Point(59, 75);
            lbProduto.Name = "lbProduto";
            lbProduto.Size = new Size(55, 15);
            lbProduto.TabIndex = 3;
            lbProduto.Text = "Produto:";
            // 
            // txtPrecoProduto
            // 
            txtPrecoProduto.AutoSize = true;
            txtPrecoProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPrecoProduto.Location = new Point(72, 104);
            txtPrecoProduto.Name = "txtPrecoProduto";
            txtPrecoProduto.Size = new Size(42, 15);
            txtPrecoProduto.TabIndex = 4;
            txtPrecoProduto.Text = "Preço:";
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbDescricao.Location = new Point(50, 133);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(64, 15);
            lbDescricao.TabIndex = 5;
            lbDescricao.Text = "Descrição:";
            // 
            // btSalvar
            // 
            btSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSalvar.Location = new Point(120, 159);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 6;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            btExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btExcluir.Location = new Point(218, 159);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 23);
            btExcluir.TabIndex = 7;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // lstProdutos
            // 
            lstProdutos.FormattingEnabled = true;
            lstProdutos.Items.AddRange(new object[] { "Lista de Produtos", "" });
            lstProdutos.Location = new Point(310, 72);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(466, 259);
            lstProdutos.TabIndex = 8;
            // 
            // FormProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstProdutos);
            Controls.Add(btExcluir);
            Controls.Add(btSalvar);
            Controls.Add(lbDescricao);
            Controls.Add(txtPrecoProduto);
            Controls.Add(lbProduto);
            Controls.Add(txtDescricao);
            Controls.Add(textBox2);
            Controls.Add(txtNomeProduto);
            Name = "FormProdutos";
            Text = "FormProdutos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeProduto;
        private TextBox textBox2;
        private TextBox txtDescricao;
        private Label lbProduto;
        private Label txtPrecoProduto;
        private Label lbDescricao;
        private Button btSalvar;
        private Button btExcluir;
        private ListBox lstProdutos;
    }
}