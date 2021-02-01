using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Model
{
    class ContaInvestimento : Conta
    {
        public double SaldoInvestimento { get; set; }


        public ContaInvestimento()
        {

        }
        public ContaInvestimento(double saldoInvestimento)
        {
            SaldoInvestimento = saldoInvestimento;
        }
    }
}


