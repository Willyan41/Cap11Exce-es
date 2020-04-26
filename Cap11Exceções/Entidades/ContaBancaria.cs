using System;
using System.Collections.Generic;
using System.Text;
using Cap11Exceções.Entidades.Exceção;

namespace Cap11Exceções.Entidades
{
    class ContaBancaria
    {

        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public ContaBancaria() { }

        public ContaBancaria(int numero, string titular, double saldo, double limiteSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;

        }

        public void Deposito(double quantidade)
        {
            Saldo += quantidade;
        }

        public void Saque(double quantidade)
        {

            if (Saldo < quantidade)
            {
                throw new DomainException ( "Saldo insuficiente para saque.");
            }
            else if (quantidade > LimiteSaque)
            {
                throw new DomainException("O valor excede o limite de saque.");
            }
            else 
            Saldo -= quantidade;

        }
    }
}
