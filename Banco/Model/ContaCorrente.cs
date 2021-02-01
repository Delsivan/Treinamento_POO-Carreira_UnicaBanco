using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Banco.Model
{
    class ContaCorrente : Conta
    {

        public double LimiteEmprestimo { get; set; }


        public ContaCorrente()
        {

        }

        public ContaCorrente(string titular, int agencia, int numero, double saldo, double limiteEmprestimo) : base(titular, agencia, numero, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;

        }

        public override string ToString()
        {
            return "NOME: " + Titular + ", AGÊNCIA: " + Agencia + ", CONTA: " + Numero +  ", SALDO: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }

}
