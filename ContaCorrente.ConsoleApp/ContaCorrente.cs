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

        public int DefinirPosicaoParaMovimentacao()
        {
            int posicao = -1;//caso não exista posicao retorna -1
            for (int i = 0; i < movimentacoes.Length; i++)
            {
                if (movimentacoes[i] == null)
                {
                    posicao = i;
                    break;
                }
            }
            return posicao;
        }

        public bool Sacar(double valor_saque)
        {
            bool saque_efetuado = false;
            if (valor_saque < (this.limite + this.saldo))
            {
                double novo_saldo = this.saldo - valor_saque;
                this.saldo = novo_saldo;

                Movimentacao movimentacao_saque = new Movimentacao();
                movimentacao_saque.tipos = TipoMovimentacao.Debito;
                movimentacao_saque.valor = valor_saque;
                int posicao = DefinirPosicaoParaMovimentacao();
                if (posicao != -1)
                {
                    movimentacoes[posicao] = movimentacao_saque;
                }
                saque_efetuado = true;
            }
            else
            {
                Console.WriteLine("\nSeu limite é de R$ " + this.limite + ", Operação Inválida!");
            }
            return saque_efetuado;
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
                movimentacao_deposito.tipos = TipoMovimentacao.Credito;
                movimentacao_deposito.valor = valor_deposito;
                int posicao = DefinirPosicaoParaMovimentacao();
                if (posicao != -1)
                {
                    movimentacoes[posicao] = movimentacao_deposito;
                }
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("\nSaldo da conta " + this.numero + " é de R$ " + this.saldo);
        }

        public void Transferir(ContaCorrente conta_destino, double valor_transferencia)
        {
            if (Sacar(valor_transferencia) == true)
            {
                conta_destino.Depositar(valor_transferencia);
            }
        }

        public void ExibirMovimentacao()
        {
            Console.WriteLine("Conta " + numero);
            for (int i = 0; i < movimentacoes.Length; i++)
            {
                if (movimentacoes[i] != null)
                {
                    Console.WriteLine("Movimentação do tipo " + movimentacoes[i].tipos + " no valor de " + movimentacoes[i].valor);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
