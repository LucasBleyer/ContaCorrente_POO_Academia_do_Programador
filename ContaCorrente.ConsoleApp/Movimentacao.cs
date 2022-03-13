using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    internal class Movimentacao
    {
        public double valor;
        public TipoMovimentacao tipos;

        public enum TipoMovimentacao
        {
            Credito, Debito
        }

    }
}
