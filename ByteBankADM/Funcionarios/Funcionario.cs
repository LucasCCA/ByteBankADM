using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankADM.Funcionarios
{
    public abstract class Funcionario : IBonificacao
    {
        //0 - funcionario
        //1 - diretor
        //2 - analista
        //N - ...
        //private int tipo;

        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        
        //public virtual double GetPremio()
        //{
        //    return this.Salario * 0.2;
        //}

        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf; 
            TotalDeFuncionarios++;
            //Console.WriteLine("Funcionario criado");
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
