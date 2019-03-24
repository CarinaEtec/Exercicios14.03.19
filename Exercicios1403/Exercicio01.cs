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
    public partial class Exercicio01 : Form
    {
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string LOGIN;
            string SENHA;
            LOGIN = Convert.ToString(txtLogin.Text);
            SENHA = Convert.ToString(txtSenha.Text);


            E1_Login log = new E1_Login(LOGIN, SENHA);
            if (log.Verificar() == (true))
            {
                MessageBox.Show("Acesso Permitido");
            }
            else
            {
                MessageBox.Show("Acesso negado");
            }



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
