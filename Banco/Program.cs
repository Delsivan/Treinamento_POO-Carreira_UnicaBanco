using System;
using Banco.Model;
using System.Globalization;
using Banco.Services;


namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcao = 0;

            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Digite a agencia da conta: ");
            int agencia = int.Parse(Console.ReadLine());
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(titular, agencia, numero, 1000, 2000);
            ContaService contaService = new ContaService(conta);
            ContaInvestimento contaInvestimento = new ContaInvestimento(1000);

            Console.WriteLine();
            Console.WriteLine(@" -------- Dados da conta --------");
            Console.WriteLine();
            Console.WriteLine(conta);
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine(" ..:: Selecione uma opção ::..");
                Console.WriteLine();
                Console.WriteLine("1 - Depósito");
                Console.WriteLine("2 - Saque");
                Console.WriteLine("3 - Transferência");
                Console.WriteLine("4 - Emprestimo");
                Console.WriteLine("5 - Investimento");
                Console.WriteLine("0 - Sair");

                Console.WriteLine();
                Console.Write("Selecione a opção desejada:");

                opcao = int.Parse(Console.ReadLine());


                if (opcao == 1)
                {
                    Console.WriteLine();
                    Console.Write("Entre com um Valor para depósito: ");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contaService.OperacaoDeposito(valor);
                }

                else if (opcao == 2)
                {
                    Console.WriteLine();
                    Console.Write("Entre com um Valor para Saque: ");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contaService.OperacaoSaque(valor);
                }

                else if (opcao == 3)
                {
                    Console.WriteLine();
                    Console.Write("Digite o nome do titular da conta: ");
                    titular = Console.ReadLine();
                    Console.Write("Digite a agencia da conta: ");
                    agencia = int.Parse(Console.ReadLine());
                    Console.Write("Digite o número da conta: ");
                    numero = int.Parse(Console.ReadLine());

                    Console.Write("Entre com um Valor para Transferencia: ");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contaService.OperacaoTransferir(valor);
                }
                else if (opcao == 4)
                {
                    Console.Write("Digite o valor para emprestimo: ");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contaService.Emprestimo(valor);
                }
                else if (opcao == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine(" ..:: Selecione uma opção ::..");
                    Console.WriteLine();
                    Console.WriteLine("1 - Depósito");
                    Console.WriteLine("2 - Saque");

                    var s = Console.ReadKey();

                    switch (s.KeyChar)
                    {
                        case '1':
                            Console.WriteLine();
                            Console.Write("Entre com um Valor para depósito: ");
                            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            contaService.OperacaoDeposito(valor);
                            break;

                        case '2':
                            Console.WriteLine();
                            Console.Write("Entre com um Valor para Saque: ");
                            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            contaService.OperacaoSaque(valor);
                            break;

                        default:
                            Console.WriteLine(" Opção Inválida");
                            break;
                    }
                }
                else if (opcao == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                }

            }
        }

    }
}
