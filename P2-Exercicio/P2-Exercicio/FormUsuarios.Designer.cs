namespace P2_Exercicio
{
    partial class FormUsuarios
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
            lbUsuario = new Label();
            lbSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btCadastrar = new Button();
            btExcluir = new Button();
            btAlterarSenha = new Button();
            lstUsuarios = new ListBox();
            SuspendLayout();
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbUsuario.Location = new Point(3, 68);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(52, 15);
            lbUsuario.TabIndex = 0;
            lbUsuario.Text = "Usuário:";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSenha.Location = new Point(11, 97);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(44, 15);
            lbSenha.TabIndex = 1;
            lbSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(61, 65);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(198, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(61, 94);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(198, 23);
            txtSenha.TabIndex = 3;
            // 
            // btCadastrar
            // 
            btCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCadastrar.Location = new Point(61, 123);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(75, 23);
            btCadastrar.TabIndex = 4;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btExcluir.Location = new Point(184, 123);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 23);
            btExcluir.TabIndex = 5;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAlterarSenha
            // 
            btAlterarSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btAlterarSenha.Location = new Point(108, 152);
            btAlterarSenha.Name = "btAlterarSenha";
            btAlterarSenha.Size = new Size(107, 23);
            btAlterarSenha.TabIndex = 6;
            btAlterarSenha.Text = "Alterar Senha";
            btAlterarSenha.UseVisualStyleBackColor = true;
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.Items.AddRange(new object[] { "Exibir Usuários" });
            lstUsuarios.Location = new Point(277, 65);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(229, 289);
            lstUsuarios.TabIndex = 7;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 450);
            Controls.Add(lstUsuarios);
            Controls.Add(btAlterarSenha);
            Controls.Add(btExcluir);
            Controls.Add(btCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lbSenha);
            Controls.Add(lbUsuario);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsuario;
        private Label lbSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btCadastrar;
        private Button btExcluir;
        private Button btAlterarSenha;
        private ListBox lstUsuarios;
    }
}