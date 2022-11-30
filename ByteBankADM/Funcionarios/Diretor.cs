using ByteBankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }

        //public override double GetPremio()
        //{
        //    return this.Salario + base.GetPremio();
        //}

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public Diretor(string cpf) : base(cpf, 5000)
        {
            //Console.WriteLine("Diretor criado");
        }
    }
}
