using DesafioAula8;

//Escrever um programa que recebe 3 cadastros de contas bancárias com o saldo.
//Depois perguntar para o usuário qual conta ele quer exibir os dados completos.
string mensagem = "";

try
{
    string tipoConta = "";
    int agenciaConta;
    int numeroConta;
    double saldoConta;

    Console.WriteLine("Bem vindo ao cadastro de contas bancárias");
    Console.WriteLine("Serão cadastradas 3 contas diferentes");

    List<ContaBancaria> listaContas = new List<ContaBancaria>();

    for (int i = 1; i <= 1; i++)
    {
        Console.WriteLine("CADASTRE UMA NOVA CONTA");

        Console.WriteLine($"Digite o tipo da conta {i}:");
        tipoConta = Console.ReadLine();

        Console.WriteLine($"Digite a agência da conta {i}:");
        agenciaConta = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Digite o número da conta {i}:");
        numeroConta = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Digite o saldo da conta {i}:");
        saldoConta = Convert.ToDouble(Console.ReadLine());

        ContaBancaria contaBancaria = new ContaBancaria(tipoConta, agenciaConta, numeroConta, saldoConta);

        listaContas.Add(contaBancaria);
    }

    Console.WriteLine("Qual o número da conta que você gostaria de visualizar?");
    numeroConta = Convert.ToInt32(Console.ReadLine());

    if(listaContas.Where(conta => conta.Numero == numeroConta).Any()){
        ContaBancaria contaBancariaBusca = listaContas.Where(conta => conta.Numero == numeroConta).FirstOrDefault();
        mensagem = contaBancariaBusca.ExibirDadosConta();
    }
    else
    {
        mensagem = "Conta não encontrada";
    }
    
}
catch (Exception ex)
{
    mensagem = $"O erro encontrado no sistema foi: {ex.Message}";
}
finally
{
    Console.WriteLine(mensagem);
}