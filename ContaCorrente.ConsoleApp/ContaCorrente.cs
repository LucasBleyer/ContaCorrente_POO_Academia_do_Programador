﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    internal class ContaCorrente
    {
        public int numero;
        public int saldo;
        public bool ehEspecial;
        public int limite;
        public Movimentacao[] movimentacoes;

        public int Sacar(int valor_sacar)
        {
            int saque = saldo - valor_sacar;
            return saque;
        }

        public int Depositar(int valor_depositar)
        {
            int deposito = saldo + valor_depositar;
            return deposito;
        }

        public void EmitirSaldo()
        {
            if (saldo > 0)
            {
                Console.WriteLine("O Saldo da conta " + numero + " é de " + saldo + "R$");
            }
            else
            {
                Console.WriteLine("Saldo Negativo!");
            }
        }

        public void EmitirExtrato()
        {

        }

        public void EmitirTransferencias()
        {

        }
    }
}
