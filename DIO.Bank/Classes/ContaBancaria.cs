using System;

namespace DIO.Bank
{
    public class ContaBancaria
    {
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private TipoConta TipoConta { get; set; }

        public ContaBancaria(string nome, double saldo, double credito, TipoConta tipoConta)
        {
            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;
            this.TipoConta = tipoConta;
        }

        public bool Sacar(double valorSaque)
        {
            bool saldoInsuficiente = this.Credito - valorSaque < (this.Credito * (-1));

            if(saldoInsuficiente)
            {
                Console.WriteLine(Resource.SALDO_INSUFICIENTE);
                return false;
            }

            this.Saldo -= valorSaque;
            Console.WriteLine(Resource.SALDO_ATUAL, this.Nome, this.Saldo);
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine(Resource.SALDO_ATUAL, this.Nome, this.Saldo);
        }

        public void Transferir(double valorTransferencia, ContaBancaria contaDestino)
        {
            if(this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            } 
        }

        public override string ToString()
        {
            return string.Concat("TipoConta ", this.TipoConta, Resource.SEPARADOR, 
                                "Nome ", this.Nome, Resource.SEPARADOR,
                                "Saldo R$ ", this.Saldo, Resource.SEPARADOR,
                                "Crédito R$ ", this.Credito).ToString();                       
        }
    }
}