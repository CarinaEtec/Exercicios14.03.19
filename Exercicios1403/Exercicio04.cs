using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios1403
{
    public partial class Exercicio04 : Form
    {
        public Exercicio04()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string DSEMANA;
            double PRECO;
            DSEMANA = Convert.ToString(txtDSemana.Text);
            PRECO = Convert.ToDouble(txtPreco.Text);

            E4_Rolezinho miih = new E4_Rolezinho(DSEMANA, PRECO);

            miih.Verificar();
            txtNovoValor.Text = Convert.ToString(miih.Desconto + ",00");

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string DSEMANA;
            double PRECO;
            DSEMANA = Convert.ToString(txtDSemana.Text);
            PRECO = Convert.ToDouble(txtPreco.Text);
            E4_Rolezinho miih = new E4_Rolezinho(DSEMANA, PRECO);

            miih.Filme = Convert.ToString(txtFilme.Text);
            miih.Nsala = Convert.ToUInt16(txtNSala.Text);
            miih.Verificar();
            MessageBox.Show("Nome do filme: " + miih.Filme + "\nNúmero da sala: " + miih.Nsala +
                "\nDia da semana: " + miih.Diasemana + "\nNovo valor: " + miih.Desconto + ",00");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 voltar = new Form1();
            voltar.Closed += (s, args) => this.Close();
            voltar.Show();
        }
    }
}
