using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SondagemQuadratica tabela;
        public Form1()
        {
            tabela = new SondagemQuadratica(7);
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (txtChave.Text != "")
            {
                int ondeDados, ondePessoa = -1;
                string chaveProc = txtChave.Text.ToUpper().PadRight(15, ' ').Substring(0, 15);

                if (!tabela.Existe(chaveProc, out ondeDados))
                    MessageBox.Show("Chave não encontrada!");
                else
                {
                    Pessoa aPessoa = tabela.GetPessoa(ondeDados);
                    txtNome.Text = aPessoa.Nome;
                }
            }
            else
                MessageBox.Show("Preencha a chave procurada!");
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            if (txtChave.Text != "" && txtNome.Text != "")
            {
                var umaNovaPessoa = new Pessoa(txtChave.Text, txtNome.Text);
                if (!tabela.Inserir(umaNovaPessoa))
                    MessageBox.Show("Chave repetida; inclusão não efetuada!");
            }
            else
                MessageBox.Show("Preencha os dois campos de dados!");
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                tabela.LerDeArquivo(dlgAbrir.FileName);
                btnListar.PerformClick();
            }
        }
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            tabela.SalvarEmArquivo(dlgAbrir.FileName);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvPessoa.RowCount = tabela.Tamanho;
            dgvPessoa.ColumnCount = 2;
            int numeroLinha = 0;

            for (int i = 0; i < tabela.Tamanho; i++)
            {
                dgvPessoa[0, numeroLinha].Value = numeroLinha;
                string ret = "";
                if (tabela[i] != null)
                    ret = tabela[i].ToString();
                dgvPessoa[1, numeroLinha].Value = ret;
                numeroLinha++;
            }
        }
    }
}
