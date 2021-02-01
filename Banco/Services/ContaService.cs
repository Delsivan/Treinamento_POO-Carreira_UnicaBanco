using Banco.Model;
using System;

namespace Banco.Services
{
    public class ContaService : IContaService
    {
        private Conta _conta;
        public ContaService(Conta conta)
        {
            _conta = conta;    
        }
        public virtual void OperacaoSaque(double valor)
        {
            if (_conta.Saldo < valor)
            {
                Console.WriteLine();
                Console.WriteLine($"Não foi possível concluir a transação. Seu saldo {_conta.Saldo} é inferior ao valor do saque {valor}!");
            }
            else
            {
                _conta.Saldo -= valor;
                Console.WriteLine();
                Console.WriteLine("Transação realizada com sucesso!");
                Console.WriteLine();

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("EXTRATO");
                DateTime d1 = DateTime.Now;
                Console.WriteLine(d1);
                //Console.WriteLine(DateTime.Now.ToString("dd'-'MM'-'yyyy"));
                Console.WriteLine("SALDO:" + _conta.Saldo.ToString("F2"));
                Console.WriteLine();
            }

        }

        public void OperacaoDeposito(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("O valor não deve ser menor que zero");
                return;
            }

            _conta.Saldo += valor;
            Console.WriteLine();
            Console.WriteLine("Transação realizada com sucesso!");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("EXTRATO");
            Console.WriteLine(DateTime.Now.ToString("dd'-'MM'-'yyyy"));
            Console.WriteLine("SALDO:" + _conta.Saldo.ToString("F2"));
            Console.WriteLine();
        }

        public void OperacaoTransferir(double valor)
        {
            if (_conta.Saldo < valor)
            {
                Console.WriteLine();
                Console.WriteLine($"Não foi possível concluir a transação. Seu saldo {_conta.Saldo} é inferior ao valor que deseja transferir {valor}!");
            }
            else
            {
                _conta.Saldo -= valor;
                Console.WriteLine();
                Console.WriteLine("Transferencia realizada com sucesso!");
                Console.WriteLine();

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("EXTRATO");
                Console.WriteLine(DateTime.Now.ToString("dd'-'MM'-'yyyy"));
                Console.WriteLine("SALDO:" + _conta.Saldo.ToString("F2"));
                Console.WriteLine();
            }
        }

        public void Emprestimo(double valor)
        {
            if (_conta.LimiteEmprestimo <= valor)
            {
                _conta.Saldo += valor;

                Console.WriteLine();
                Console.WriteLine("Emprestimo realizado com sucesso!");
                Console.WriteLine();

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("EXTRATO");
                Console.WriteLine(DateTime.Now.ToString("dd'-'MM'-'yyyy"));
                Console.WriteLine("SALDO:" + _conta.Saldo.ToString("F2"));
                Console.WriteLine();
            }

        }
    }
}
