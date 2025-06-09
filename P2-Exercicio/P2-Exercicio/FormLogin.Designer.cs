namespace P2_Exercicio
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            lbUsuario = new Label();
            lbSenha = new Label();
            btLogin = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(97, 80);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(145, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(97, 109);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(145, 23);
            txtSenha.TabIndex = 1;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbUsuario.Location = new Point(39, 83);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(52, 15);
            lbUsuario.TabIndex = 2;
            lbUsuario.Text = "Usuário:";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSenha.Location = new Point(47, 112);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(44, 15);
            lbSenha.TabIndex = 3;
            lbSenha.Text = "Senha:";
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btLogin.Location = new Point(127, 138);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(75, 23);
            btLogin.TabIndex = 4;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 276);
            Controls.Add(btLogin);
            Controls.Add(lbSenha);
            Controls.Add(lbUsuario);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Name = "FormLogin";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label lbUsuario;
        private Label lbSenha;
        private Button btLogin;
    }
}
