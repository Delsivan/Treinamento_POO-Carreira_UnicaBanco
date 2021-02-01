using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Model
{
    public class Conta
    {
        public string Titular { get;  private set; }
        public int Agencia { get; private set; }
        public int Numero { get; private set; }
        public double Saldo { get; set; }
        public double LimiteEmprestimo { get; internal set; }

        public Conta()
        {

        }
        public Conta(string titular, int agencia, int numero, double saldo)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
        }

    }
}
