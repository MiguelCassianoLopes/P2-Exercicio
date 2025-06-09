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
        }
        private void AbrirPrincipal(string usuario)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
