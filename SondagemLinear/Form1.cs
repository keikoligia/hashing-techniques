using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SondagemLinear
{
    public partial class Form1 : Form
    {
        SondagemLinear sondLinTabela;
        public Form1()
        {
            sondLinTabela = new SondagemLinear(7);
            InitializeComponent();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtChave.Text != "" && txtNome.Text != "")
            {
                var umaNovaPessoa = new Pessoa(txtChave.Text, txtNome.Text);
                if (!sondLinTabela.Inserir(umaNovaPessoa))
                    MessageBox.Show("Chave repetida; inclusão não efetuada!");
            }
            else
                MessageBox.Show("Preencha os dois campos de dados!");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtChave.Text != "")
            {
                int ondeDados, ondePessoa = -1;
                string chaveProc = txtChave.Text.ToUpper().PadRight(15, ' ').Substring(0, 15);

                if (!sondLinTabela.Existe(chaveProc, out ondeDados))
                    MessageBox.Show("Chave não encontrada!");
                else
                {
                    Pessoa aPessoa = sondLinTabela.GetPessoa(ondeDados);
                    txtNome.Text = aPessoa.Nome;
                }
            }
            else
                MessageBox.Show("Preencha a chave procurada!");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvListagemHash.RowCount = sondLinTabela.Tamanho;
            dgvListagemHash.ColumnCount = 2;
            int numeroLinha = 0;

            for (int i = 0; i < sondLinTabela.Tamanho; i++)
            {
                dgvListagemHash[0, numeroLinha].Value = numeroLinha;
                string ret = "";
                if (sondLinTabela[i] != null)
                    ret = sondLinTabela[i].ToString();
                dgvListagemHash[1, numeroLinha].Value = ret;
                numeroLinha++;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                sondLinTabela.LerDeArquivo(dlgAbrir.FileName);
                btnListar.PerformClick();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sondLinTabela.SalvarEmArquivo(dlgAbrir.FileName);
        }
    }
}
