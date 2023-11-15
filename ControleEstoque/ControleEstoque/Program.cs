using System;
using System.Globalization;


namespace ControleEstoque
{
    class Program
    {

        static void Main(string[] args) {


            Console.Write("Insira o nome do Produto: ");
            string nome = Console.ReadLine();
            Console.Write("Insira o valor do Produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Insira a quantidade do Produto: ");
            int quantidade = int.Parse(Console.ReadLine());


            Produto p= new Produto(nome, preco, quantidade);
            Console.WriteLine( );

            Console.WriteLine("Dados do Produto: "+ p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            int qtdAdd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtdAdd);

            Console.WriteLine("Dados Atualizados: "+ p);


            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int qtdRmv = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qtdRmv);



            Console.WriteLine("Dados Atualizados: " + p);




        }







    }


}