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
    public partial class Exercicio03 : Form
    {
        public Exercicio03()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 voltar = new Form1();
            voltar.Closed += (s, args) => this.Close();
            voltar.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


            double ALTURA;
            double PESO;
            ALTURA = Convert.ToDouble(txtAltura.Text);
            PESO = Convert.ToDouble(txtAltura.Text);


            E3_Pessoa people = new E3_Pessoa(ALTURA, PESO);

            people.Altura = Convert.ToDouble(txtAltura.Text);
            people.Peso = Convert.ToDouble(txtPeso.Text);

            people.Calcular();
            MessageBox.Show(people.Condicao);
        }
    }
}
