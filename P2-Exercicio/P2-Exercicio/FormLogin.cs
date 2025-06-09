namespace P2_Exercicio
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "ADMIN" && senha == "123")
            {
                AbrirPrincipal("ADMIN");
                return;

            }
            if (File.Exists("C:\\Users\\Computador\\source\\repos\\P2-Exercicio\\usuarios.csv"))
            {
                var linhas = File.ReadAllLines("C:\\Users\\Computador\\source\\repos\\P2-Exercicio\\usuarios.csv");
                foreach (var linha in linhas)
                {
                    var partes = linha.Split(',');
                    if (partes.Length == 2 && partes[0] == usuario && partes[1] == senha)
                    {
                        AbrirPrincipal(usuario);
                        return;
                    }

                }
            }

            MessageBox.Show("Usuário ou senha inválidos!");
        }
        private void AbrirPrincipal(string usuario)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
