using System;

namespace Aprendendo_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "Alef";
            cliente.CPF = "45665445698";
            cliente.Profissao = "Desenvolvedor"; 

            ContaCorrente conta = new ContaCorrente(867, 86712540);
            conta.Saldo = -10;
            conta.Titular = cliente;
            Console.WriteLine(conta.Saldo);
        }
    }
}
