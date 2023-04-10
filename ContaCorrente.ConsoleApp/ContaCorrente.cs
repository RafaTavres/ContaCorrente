using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    internal class ContaCorrente
    {
        public int numero;
        public string titular;
        public string tipoDeTransferencia;
        public decimal saldo;
        public bool contaEspecial;
        public decimal limite;
        public List<Movimentacao> movimentacoes = new List<Movimentacao>();
        public decimal Saque(decimal quantidade)
        {
            if (quantidade >= limite+saldo)
            {
                return saldo;
            }
            else
            {
                Movimentacao movimentacao = new Movimentacao("Credito", quantidade);
                movimentacoes.Add(movimentacao);
                return saldo -= quantidade;
            }
        }
        public decimal Deposito(decimal quantidade)
        {
            Movimentacao movimentacao = new Movimentacao("Debito",quantidade);
            movimentacoes.Add(movimentacao);
            return saldo += quantidade;
        }
        public void VisualizaçãoSaldo()
        {
            Console.WriteLine("Saldo Atual: "+ saldo);
        }
        public void VisualizaExtrato()
        {
            Console.WriteLine("Extrato Atual: ");
            foreach (var item in movimentacoes)
            {
                if (item.tipoDeMovimentacao.Equals("Transferencia"))
                {}
                else
                    Console.WriteLine($"Tipo: {item.tipoDeMovimentacao} | Quantidade: {item.quantidadeMovimentada}");
            }
        }
        public void VisualizaTransferencia()
        {
            Console.WriteLine("Transferencias: ");
            foreach (var item in movimentacoes)
            {
                if (item.tipoDeMovimentacao.Equals("Credito") || item.tipoDeMovimentacao.Equals("Debito"))
                {}else
                 Console.WriteLine($"Tipo: {item.tipoDeTransferencia} | De {item.remetente}, na Quantidade de {item.quantidadeMovimentada} Para {item.destinatario}");
            }
        }
        public void TransferênciaPara(ContaCorrente contaDestino,decimal quantidade)
        {
            Movimentacao movimentacao = new Movimentacao("Transferencia", tipoDeTransferencia, quantidade, contaDestino.titular, this.titular);
            movimentacoes.Add(movimentacao);
            this.Saque(quantidade);
            contaDestino.Deposito(quantidade);
        }
    }
}
