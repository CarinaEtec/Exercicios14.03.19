using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1403
{
    class E1_Login
    {
        private string login_usu;
        private string senha_usu;

        public string Login_usu { get => login_usu; set => login_usu = value; }
        public string Senha_usu { get => senha_usu; set => senha_usu = value; }


        public E1_Login(string LOGIN, string SENHA)
        {
            login_usu = LOGIN;
            Senha_usu = SENHA;
        }

        public bool Verificar()
        {
            if (this.login_usu == "admin" && this.senha_usu == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
