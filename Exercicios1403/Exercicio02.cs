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
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double SalarioBase;
            SalarioBase = Convert.ToDouble(txtSalarioBase.Text);
            int Ndependentes;
            Ndependentes = Convert.ToInt16(txtNDependentes.Text);

            E2_Pessoa people = new E2_Pessoa(SalarioBase, Ndependentes);
            people.SalarioFamilia();

            lblSalFamilia.Text = Convert.ToString(people.Salariofamilia);
        }

        private void btnMostraDados_Click(object sender, EventArgs e)
        {
            E2_Pessoa people = new E2_Pessoa();

            people.Nome = txtNome.Text;
            people.Sexo = txtSexo.Text;
            people.Ndependentes = Convert.ToInt16(txtNDependentes.Text);
            people.Salariobase = Convert.ToDouble(txtSalarioBase.Text);


            MessageBox.Show("Nome: " + people.Nome + "\n" + "Sexo: " + people.Sexo + "\n" +
                "Número de Dependentes: " + people.Ndependentes + "\n" + "Salário Base: " + people.Salariobase +
                "\n" + "Salário família: " + people.SalarioFamilia());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 voltar = new Form1();
            voltar.Closed += (s, args) => this.Close();
            voltar.Show();
        }
    }
}
