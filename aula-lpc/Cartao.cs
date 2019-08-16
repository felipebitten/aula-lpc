using System;
namespace aula2
{
    public class Cartao
    {
        Conta objConta = new Conta(1234, "Felipe");
        public Cartao(int ncartao, int mes, int ano)
        {
            this.ncartao = ncartao;
            this.mes = mes;
            this.ano = ano;
        }

        public int ncartao { get; private set; }

        public int mes { get; private set; }

        public int ano { get; private set; }

        public void Validade ()
        {
            Console.WriteLine("Validade do Cartão: Mês: " + mes + " Ano: " + ano);
        } 

        public void NumeroCartao (){
            if(objConta.numero == ncartao){
                Console.WriteLine("Conta correta!");
            }else{
                Console.WriteLine("Conta incorreta!");
            }
        }

    }
}