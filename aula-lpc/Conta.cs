namespace aula2
{
    public class Conta
    {

        public Conta (int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
        }

        public int numero { get; private set; }

        public int limite { get; private set; }

        public string titular { get; private set; }

        public decimal saldo { get; private set; }
        

        public void Depositar (decimal valor){
            saldo += valor;
        } 

        public int Limite(int limite)
        {
            limite = 100;
            return limite;
        }

        public void Sacar(decimal valor){
            saldo -= valor;
        }

    }
}