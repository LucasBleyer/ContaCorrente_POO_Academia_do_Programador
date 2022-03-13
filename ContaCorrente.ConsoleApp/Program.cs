using System;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta_lucas = new ContaCorrente();
            conta_lucas.numero = 1234;
            conta_lucas.saldo = 1000;
            conta_lucas.limite = 400;
            conta_lucas.ehEspecial = false;
            conta_lucas.movimentacoes = new Movimentacao[10];

            conta_lucas.Sacar(200);

            conta_lucas.Depositar(300);

            conta_lucas.Depositar(500);

            conta_lucas.Sacar(200);
        }
    }
}
