using Cap11Exceções.Entidades;
using Cap11Exceções.Entidades.Exceção;
using System;
using System.Globalization;

namespace Cap11Exceções
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com o dados da conta: ");
                Console.Write("Numero: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string titular = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de saque: ");
                double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ContaBancaria acc = new ContaBancaria(numero, titular, saldoInicial, limiteSaque);

                Console.WriteLine();

                Console.Write("Entre com a quantidade de saque: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Saque(saque);

                Console.WriteLine("Saldo Atualizado: "+ acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erro: "+ ex.Message);
            }

        }
    }
}
