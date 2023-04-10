using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    internal class Movimentacao
    {
        public string Tipo;
        public string tipoDeTransferencia;
        public decimal quantidadeMovimentada;
        public string Destinatario;
        public string Remetente;

        public Movimentacao(string tipo, decimal quantidadeMovimentada)
        {
            Tipo = tipo;
            this.quantidadeMovimentada = quantidadeMovimentada;
        }

        public Movimentacao(string tipo, string tipoDeTransferencia, decimal quantidadeMovimentada, string destinatario, string remetente)
        {
            Tipo = tipo;
            this.tipoDeTransferencia = tipoDeTransferencia;
            this.quantidadeMovimentada = quantidadeMovimentada;
            Destinatario = destinatario;
            Remetente = remetente;
        }
    }
}
