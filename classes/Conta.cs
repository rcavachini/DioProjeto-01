using System;
namespace BancoNet
{
    public class Conta
    {
        public Conta(TipoConta tipoConta, string nome, double credito, double saldo)
        {
            this.TipoConta = tipoConta;
            this.Nome = nome;
            this.Credito = credito;
            this.Saldo = saldo;

        }
        private TipoConta TipoConta { get; set; }
        private string Nome { get; set; }
        public double Credito { get; set; }
        public double Saldo { get; set; }

        public bool Sacar(double valorSaque)
        {
            if(this.Saldo - valorSaque < (this.Credito *-1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta do Sr.:{0} é de: R$ {1}",this.Nome,this.Saldo);
            return true;
        }
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Saldo atual da conta do Sr.:{0} é de: R$ {1}",this.Nome,this.Saldo);
        }
        public void Transferir(double valorTransferencia,Conta contaDestino)
        {
            if(this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }



        public override string ToString()
        {
            string retorno = "";
            retorno +="|| TipoConta: " + this.TipoConta + " | ";
            retorno +="Nome: " + this.Nome + " | ";
            retorno +="Saldo: " + this.Saldo + " | ";
            retorno +="Crédito: " + this.Credito + " || ";
            return retorno;
        }


    }
}