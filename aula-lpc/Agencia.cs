using System;
namespace aula2
{
    public class Agencia
    {
    public Agencia(int nagencia, string cidade)
        {
            this.nagencia = nagencia;
            this.cidade = cidade;
        }

        public int nagencia { get; private set; }

        public string cidade { get; private set; }

        public void Cidade (){
            Console.WriteLine(cidade);
        } 

      public void NumeroAgencia (){
            Console.WriteLine(nagencia);
        } 

    }
}