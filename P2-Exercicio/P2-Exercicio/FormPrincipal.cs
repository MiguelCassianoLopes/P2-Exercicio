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
    public partial class FormPrincipal : Form
    {
        private string usuarioLogado;
        
        public FormPrincipal(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            tsUsuarios.Visible = usuario == "ADMIN";
            
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tsClientes_Click(object sender, EventArgs e)
        {
            FormClientes clientes = new FormClientes();
            clientes.Show();
        }

        private void tsProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos produtos = new FormProdutos();
            produtos.Show();
        }

        private void tsPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos pedidos = new FormPedidos();
            pedidos.Show();
        }

        private void tsUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios usuarios = new FormUsuarios();
            usuarios.Show();
        }
    }
}
