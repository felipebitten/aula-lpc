using System;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta objConta = new Conta(12345, "Felipe");

            w($"Num. Conta: {objConta.numero}");
            w($"Saldo do {objConta.titular} é: {objConta.saldo}");
            r();

            objConta.Depositar(1500);
            w($"Saldo do {objConta.titular} apos deposito é: {objConta.saldo}");
            r();

            objConta.Sacar(500);
            w($"Saldo do {objConta.titular} apos saque é: {objConta.saldo}");

            Cartao objCartao = new Cartao(1234, 08, 2020);

            objCartao.Validade();
            objCartao.NumeroCartao();

            Agencia agnc = new Agencia(2222, "Torres");

            w($"Cidade da agencia: ");
            agnc.Cidade();
            w($"Numero da agencia: ");
            agnc.NumeroAgencia();
        }

        static void w(string msg){
            Console.WriteLine(msg);
        }

        static void r(){
            Console.ReadLine();
        }

    }
}