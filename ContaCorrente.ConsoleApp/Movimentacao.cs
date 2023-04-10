using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    internal class Movimentacao
    {
        public string tipoDeMovimentacao;
        public string tipoDeTransferencia;
        public decimal quantidadeMovimentada;
        public string destinatario;
        public string remetente;

        public Movimentacao(string tipoMovimentacao, decimal quantidadeMovimentada)
        {
            tipoDeMovimentacao = tipoMovimentacao;
            this.quantidadeMovimentada = quantidadeMovimentada;
        }

        public Movimentacao(string tipoMovimentacao, string tipoDeTransferencia, decimal quantidadeMovimentada, string destinatario, string remetente)
        {
            tipoDeMovimentacao = tipoMovimentacao;
            this.tipoDeTransferencia = tipoDeTransferencia;
            this.quantidadeMovimentada = quantidadeMovimentada;
            this.destinatario = destinatario;
            this.remetente = remetente;
        }
    }
}
