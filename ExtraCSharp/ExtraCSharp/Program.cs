using System;
using System.Globalization;



namespace ExtraCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            // operação ternária (condição) ? ação se verdadeiro : ação se falsa;

            /*
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? preco * 0.01 : preco * 0.05;

            Console.WriteLine(desconto.ToString("F2", CultureInfo.InvariantCulture));
            */

            //Funções em Strings


            string original = "abcde FGHIJ ABC abc DEFG";
            // Converter tudo para maiusculo 
            string s1 = original.ToUpper();
            // Converter tudo para minusculo
            string s2 = original.ToLower();
            // apagar espaço em branco antes e depois da string não dentro da string
            string s3 = original.Trim();

            // procurar a primeira ocorrencia de um valor passado

            int n1 = original.IndexOf("bc");

            // procurar a ultima ocorrencia de um valor passado

            int n2 = original.LastIndexOf("bc");

            //cortar string

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            Console.WriteLine(original);
            Console.WriteLine("To Upper - " + s1);
            Console.WriteLine("To Lower - " + s2);
            Console.WriteLine("Trim - " + s3);
            
            Console.WriteLine("Index Of - " + n1);
            Console.WriteLine("Index Of - " + n2);
            Console.WriteLine("Trim - " + s4);
            Console.WriteLine("Trim - " + s5);
        }

    }





}