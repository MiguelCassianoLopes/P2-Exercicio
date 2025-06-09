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
    public partial class FormProdutos : Form
    {
        private string caminhoCsv = "C:\\Users\\Computador\\source\\repos\\P2-Exercicio\\produtos.csv";
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProduto.Text.Trim();
            string precoStr = txtPrecoProduto.Text.Trim();
            string descricao = txtDescricao.Text.Trim();

            if (!decimal.TryParse(precoStr, out decimal preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            string linha = $"{nome},{preco.ToString("F2")},{descricao}";

            File.AppendAllText(caminhoCsv, linha + Environment.NewLine);
            MessageBox.Show("Produto cadastrado com sucesso!");
            LimparCampos();
            CarregarProdutos();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProduto.Text.Trim();

            if (!File.Exists(caminhoCsv)) return;

            var linhas = File.ReadAllLines(caminhoCsv).ToList();
            var novas = linhas.Where(l => !l.StartsWith(nome + ",")).ToList();

            if (linhas.Count == novas.Count)
            {
                MessageBox.Show("Produto não encontrado.");
            }
            else
            {
                File.WriteAllLines(caminhoCsv, novas);
                MessageBox.Show("Produto excluído.");
                LimparCampos();
                CarregarProdutos();
            }
        }

        private void CarregarProdutos()
        {
            lstProdutos.Items.Clear();
            if (File.Exists(caminhoCsv))
            {
                foreach (var linha in File.ReadAllLines(caminhoCsv))
                {
                    var partes = linha.Split(',');
                    if (partes.Length >= 2)
                        lstProdutos.Items.Add($"{partes[0]} - R$ {partes[1]}");

                }
            }
        }
        private void LimparCampos()
            
            {
            txtNomeProduto.Clear();
            txtDescricao.Clear();
            txtPrecoProduto.Clear();
        }
        }
    }


