using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    public static class ContaBancariaService
    {
        public static List<ContaBancaria> contasBancarias = new List<ContaBancaria>();

        public static void Inserir()
        {
            try
            {
                Console.Write("Informe 1 para conta física ou 2 para conta jurídica ");
                int enumTipoConta = int.Parse(Console.ReadLine());

                Console.Write("Informe o nome do cliente: ");
                string nomeCliente = Console.ReadLine();

                Console.Write("Informe o saldo inicial: ");
                double saldoInicial = double.Parse(Console.ReadLine());

                Console.Write("Informe o crédiot: ");
                double credito = double.Parse(Console.ReadLine());

                ContaBancaria newConta = new ContaBancaria(nomeCliente, saldoInicial, credito, (TipoConta)enumTipoConta);
                contasBancarias.Add(newConta);
            }
            catch
            {
                Console.Write(string.Concat(Resource.ERRO_CRIAR_CONTA,Resource.PULAR_LINHA));
            }
        }

        public static void Listar()
        {
            if(contasBancarias.Count == 0)
            {
                Console.Write(string.Concat(Resource.CONTA_NAO_CADASTRADA, Resource.PULAR_LINHA));
                return;
            }

            foreach(var conta in contasBancarias)
            {
                Console.Write(conta);
            }
        }

        public static void Sacar()
        {
            try
            {
                Console.Write("Informe o número da conta: ");
                int indiceLista = int.Parse(Console.ReadLine());

                Console.Write("Informe o valor que deseja sacar: ");
                double valorSaque = double.Parse(Console.ReadLine());

                contasBancarias[indiceLista].Sacar(valorSaque);
            }
            catch
            {
                Console.Write(string.Concat(Resource.ERRO, Resource.PULAR_LINHA));
            }
        }

        public static void Depositar()
		{
            try
            {
                Console.Write("Digite o número da conta: ");
                int indiceConta = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor a ser depositado: ");
                double valorDeposito = double.Parse(Console.ReadLine());

                contasBancarias[indiceConta].Depositar(valorDeposito);
            }
            catch
            {
                Console.Write(string.Concat(Resource.ERRO, Resource.PULAR_LINHA));
            }
		}

        public static void Transferir()
		{
            try
            {
                Console.Write("Digite o número da conta de origem: ");
                int indiceContaOrigem = int.Parse(Console.ReadLine());

                Console.Write("Digite o número da conta de destino: ");
                int indiceContaDestino = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor a ser transferido: ");
                double valorTransferencia = double.Parse(Console.ReadLine());

                contasBancarias[indiceContaOrigem].Transferir(valorTransferencia, contasBancarias[indiceContaDestino]);
            }
            catch
            {
                Console.Write(string.Concat(Resource.ERRO,Resource.PULAR_LINHA));
            }
		}
    }
}