using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankADM.Funcionarios;
using ByteBankADM.Parceria;

namespace ByteBankADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Login ou senha incorreto");
                return false;
            }
        }
    }
}
