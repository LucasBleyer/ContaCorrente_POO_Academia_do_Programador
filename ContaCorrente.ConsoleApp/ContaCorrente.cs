using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    internal class ContaCorrente
    {
        public int numero;
        public double saldo;
        public double limite;
        public bool ehEspecial;
        public Movimentacao[] movimentacoes;

        public void Sacar(double valor_saque)
        {
            if (valor_saque < (this.limite + this.saldo))
            {
                double novo_saldo = this.saldo - valor_saque;
                this.saldo = novo_saldo;

                Movimentacao movimentacao_saque = new Movimentacao();
                movimentacao_saque.tipos = Movimentacao.TipoMovimentacao.Debito;
                movimentacao_saque.valor = valor_saque;
            }
            else
            {
                Console.WriteLine("\nSeu limite é de R$ " + this.limite + ", Operação Inválida!");
            }
        }

        public void Depositar(double valor_deposito)
        {
            if (valor_deposito < 0)
            {
                Console.WriteLine("\nOperação Inválida!");
            }
            else
            {
                this.saldo = this.saldo + valor_deposito;
                Movimentacao movimentacao_deposito = new Movimentacao();
                movimentacao_deposito.tipos = Movimentacao.TipoMovimentacao.Credito;
                movimentacao_deposito.valor = valor_deposito;
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("\nSaldo da conta " + this.numero + " é de R$ " + this.saldo);
        }

        public void Transferir(ContaCorrente conta_destino, double valor_transferencia)
        {
            this.saldo = this.saldo * valor_transferencia;
            conta_destino.saldo = conta_destino.saldo + valor_transferencia;
        }
    }
}
