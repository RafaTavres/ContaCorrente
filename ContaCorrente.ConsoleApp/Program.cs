namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "Marcelo";
            conta1.saldo = 10;
            conta1.numero = 12;
            conta1.limite = 0;
            conta1.contaEspecial = true;
            conta1.tipoDeTransferencia = "Credito";

            conta1.Saque(100);
            conta1.Deposito(500);
            conta1.Deposito(1000);
            conta1.VisualizaçãoSaldo();


            ContaCorrente conta2 = new ContaCorrente();
            conta2.saldo = 1000;
            conta2.titular = "Marcos";
            conta2.numero = 15;
            conta2.limite = 0;
            conta2.contaEspecial = true;
            conta2.tipoDeTransferencia = "Debito";

            conta2.Saque(500);
            conta2.Deposito(100);
            conta2.Deposito(200);
            conta2.VisualizaçãoSaldo();

            conta1.TransferênciaPara(conta2, 300);
            conta2.TransferênciaPara(conta1, 500);
            conta1.VisualizaçãoSaldo();
            conta2.VisualizaçãoSaldo();

            Console.WriteLine("=====================");
            Console.WriteLine("Conta 1: ");
            conta1.VisualizaExtrato();

            Console.WriteLine("=====================");
            Console.WriteLine("Conta 2: ");
            conta2.VisualizaExtrato();


            Console.WriteLine("======================");
            Console.WriteLine("Conta 1: ");
            conta1.VisualizaTransferencia();
            Console.WriteLine("======================");
            Console.WriteLine("Conta 2: ");
            conta2.VisualizaTransferencia();

            Console.ReadKey();
        }
    }
}