using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_Exercicio
{
    public partial class FormUsuarios : Form
    {
        private string usuarioLogado;
        private string caminhoCsv = "C:\\Users\\Computador\\source\\repos\\P2-Exercicio\\usuarios.csv";

        public FormUsuarios(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            CarregarUsuarios();
        }

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void CarregarUsuarios()
        {
            lstUsuarios.Items.Clear();
            if (File.Exists(caminhoCsv))
            {

                var linhas = File.ReadAllLines(caminhoCsv);
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(';');
                    if (dados.Length >= 1)
                    lstUsuarios.Items.Add(dados[0]);
                }
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (usuarioLogado == "ADMIN")
            {
                MessageBox.Show("Somente o administrador pode cadastrar usuários!");
                return;
            }

            string novoUsuario = txtUsuario.Text.Trim();
            string novaSenha = txtSenha.Text.Trim();

            if (novoUsuario == "" || novaSenha == "")
            {
                MessageBox.Show("Preencha os campos de usuário e senha!");
                return;
            }

            if (File.Exists(caminhoCsv) && File.ReadAllLines(caminhoCsv).Any(l => l.Split(',')[0] == novoUsuario))
            {
                MessageBox.Show("Usuário já cadastrado!");
                return;
            }

            File.AppendAllText(caminhoCsv, $"{novoUsuario},{novaSenha}{Environment.NewLine}");
            MessageBox.Show("Usuário cadastrado!");
            CarregarUsuarios();
            txtUsuario.Clear();
            txtSenha.Clear();
        }
    }
}

