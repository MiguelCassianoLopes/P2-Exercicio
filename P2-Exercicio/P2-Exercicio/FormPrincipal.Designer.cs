namespace P2_Exercicio
{
    partial class FormPrincipal
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
            msCadastros = new MenuStrip();
            tsClientes = new ToolStripMenuItem();
            tsProdutos = new ToolStripMenuItem();
            tsPedidos = new ToolStripMenuItem();
            tsUsuarios = new ToolStripMenuItem();
            msCadastros.SuspendLayout();
            SuspendLayout();
            // 
            // msCadastros
            // 
            msCadastros.Items.AddRange(new ToolStripItem[] { tsClientes, tsProdutos, tsPedidos, tsUsuarios });
            msCadastros.Location = new Point(0, 0);
            msCadastros.Name = "msCadastros";
            msCadastros.Size = new Size(548, 24);
            msCadastros.TabIndex = 0;
            msCadastros.Text = "menuStrip1";
            // 
            // tsClientes
            // 
            tsClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tsClientes.Name = "tsClientes";
            tsClientes.Size = new Size(131, 20);
            tsClientes.Text = "Cadastro de Clientes";
            tsClientes.Click += tsClientes_Click;
            // 
            // tsProdutos
            // 
            tsProdutos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tsProdutos.Name = "tsProdutos";
            tsProdutos.Size = new Size(137, 20);
            tsProdutos.Text = "Cadastro de Produtos";
            tsProdutos.Click += tsProdutos_Click;
            // 
            // tsPedidos
            // 
            tsPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tsPedidos.Name = "tsPedidos";
            tsPedidos.Size = new Size(130, 20);
            tsPedidos.Text = "Cadastro de Pedidos";
            tsPedidos.Click += tsPedidos_Click;
            // 
            // tsUsuarios
            // 
            tsUsuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tsUsuarios.Name = "tsUsuarios";
            tsUsuarios.Size = new Size(134, 20);
            tsUsuarios.Text = "Cadastro de Usuários";
            tsUsuarios.Click += tsUsuarios_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 269);
            Controls.Add(msCadastros);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MainMenuStrip = msCadastros;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            msCadastros.ResumeLayout(false);
            msCadastros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msCadastros;
        private ToolStripMenuItem tsClientes;
        private ToolStripMenuItem tsProdutos;
        private ToolStripMenuItem tsPedidos;
        private ToolStripMenuItem tsUsuarios;
    }
}