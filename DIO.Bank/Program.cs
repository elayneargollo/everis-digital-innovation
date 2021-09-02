using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaBancaria minhaConta = new ContaBancaria("Elayne Natália", 500, 200, TipoConta.PessoaFisica);
            //Console.WriteLine(minhaConta.ToString());

            string opcaoEscolhidaUsuario = Menu();

            while(opcaoEscolhidaUsuario.ToUpper() != "X")
            {
                switch(opcaoEscolhidaUsuario)
                {
                    case "1":
                        ContaBancariaService.Listar();
                        break;
                    case "2":
                        ContaBancariaService.Inserir();
                        break;
                    case "3":
                        ContaBancariaService.Transferir();
                        break;
                    case "4":
                        ContaBancariaService.Sacar();
                        break;
                    case "5":
                        ContaBancariaService.Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentException();
                }

                opcaoEscolhidaUsuario = Menu();
            }
        }

        static string Menu()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Bem vindo ao DIO Conta Bancária");
            Console.WriteLine("===================================");

            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");

            Console.WriteLine();
            Console.Write("Informe a opção desejada: ");

            string opcaoEscolhida = Console.ReadLine().ToUpper();
            Console.Clear();

            return opcaoEscolhida;
        }
    }
}
