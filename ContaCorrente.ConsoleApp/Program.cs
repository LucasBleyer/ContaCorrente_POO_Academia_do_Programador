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

            ContaCorrente conta_rech = new ContaCorrente();
            conta_rech.numero = 4321;
            conta_rech.saldo = 5000;
            conta_rech.limite = 1500;
            conta_rech.ehEspecial = true;
            conta_rech.movimentacoes = new Movimentacao[10];

            conta_rech.Sacar(200);

            conta_rech.Depositar(300);

            conta_rech.Depositar(500);

            conta_rech.Sacar(200);

            conta_lucas.Transferir(conta_rech, 100);

            conta_rech.ExibirSaldo();

            conta_lucas.ExibirMovimentacao();

            Console.ReadKey();
        }
    }
}
