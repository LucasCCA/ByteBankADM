using ByteBankADM.Funcionarios;
using ByteBankADM.Utilitario;
using ByteBankADM.SistemaInterno;
using ByteBankADM.Parceria;

#region
//Console.WriteLine("Boas Vindas, ao ByteBank Admninistraçao");

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//Funcionario pedro = new Funcionario("12345698", 2000);
//pedro.Nome = "pedro";

//Diretor roberta = new Diretor("12345678");
//roberta.Nome = "roberta";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine("Bonificaçao " + pedro.GetBonificacao());
//Console.WriteLine(roberta.Nome);
//Console.WriteLine("Bonificaçao " + roberta.GetBonificacao());

//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de Bonificacao " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de Funcionários " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salario pedro " + pedro.Salario);
//Console.WriteLine("Novo salario roberta " + roberta.Salario);
#endregion

//CalcularBonificacao();
UsarSistema();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987456");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("74581");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("852963");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificacao = " + gerenciador.TotalDeBonificacao);
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("852741");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";
    ingrid.Login = "ingrid";

    GerenteDeContas ursula = new GerenteDeContas("963741");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";
    ursula.Login = "ursula";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";
    caio.Login = "caio";

    sistema.Logar(ingrid, "ingrid", "123");
    sistema.Logar(ursula, "ursula", "963");
    sistema.Logar(caio, "caio", "999");
}

Console.ReadKey();