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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio01_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio01 E01 = new Exercicio01();
            E01.Closed += (s, args) => this.Close();
            E01.Show();
        }

        private void btnExercicio02_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio02 E02 = new Exercicio02();
            E02.Closed += (s, args) => this.Close();
            E02.Show();
        }

        private void btnExercicio03_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio03 E03 = new Exercicio03();
            E03.Closed += (s, args) => this.Close();
            E03.Show();

        }

        private void btnExercicio04_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio04 E04 = new Exercicio04();
            E04.Closed += (s, args) => this.Close();
            E04.Show();
        }
    }
}
