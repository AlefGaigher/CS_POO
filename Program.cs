using System;

namespace Aprendendo_c_
{
    class Program
    {
        static void Main(string[] args)
        {
           ContaCorrente contaCorrente = new ContaCorrente();
           contaCorrente.titular = "Gabriela";
           contaCorrente.agencia = 856;
           contaCorrente.numero = 837475;
           contaCorrente.saldo = 56.4;
        }
    }
}
