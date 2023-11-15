using ClasseBancaria;
using System;
using System.Globalization;


namespace ContaBancaria
{
    class Program { 
    
        public static void Main(string[] args) {
            
            OperacaoBanco conta;

            Console.WriteLine("--- BEM VINDO AO BANCO ---");

            Console.Write("Informe o número da conta: ");
            int idConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (S/N)? ");
            char depInicial = char.Parse(Console.ReadLine());

            double depositoInicial = 0.0;
                
            if(depInicial == 'S' || depInicial == 's')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              
                conta = new OperacaoBanco(nomeTitular, idConta, depositoInicial);

            }
            else
            {
                conta = new OperacaoBanco(nomeTitular, idConta);
            }

            

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valorDeposito);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Informe um valor desejado para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            bool permitidoSaque = conta.ValidarSaque(valorSaque);

            
            if(permitidoSaque == true)
            {
                conta.Sacar(valorSaque);
            }

            else
            {
                Console.WriteLine("Você não possui saldo suficiente para sacar o valor desejado. ");
            }
            
            
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

    







        }  
    
    
    
    
    
    }








}