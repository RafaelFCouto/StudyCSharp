using System;
using System.Globalization;




namespace Pensionato
{
    class Program
    {
        static void Main(string[] args) {


            int esc = 1;
            int cont = 1;
            int qtdQuartos = 10;

            ControlePensionato[] quartos = new ControlePensionato[qtdQuartos];

            for (int i = 0; i < qtdQuartos; i++)
            {
                quartos[i] = new ControlePensionato(i);

            }



            do
            {
                Console.WriteLine("--- GESTÃO DE PENSIONATO ---");
                Console.WriteLine("-------- MENU -------- ");
                Console.WriteLine("1 - ALUGAR QUARTO");
                Console.WriteLine("2 - STATUS QUARTOS");
                Console.WriteLine("3 - LISTAR QUARTOS ALUGADOS");
                Console.WriteLine("4 - FINALIZAR");
                Console.WriteLine();
                Console.Write("ESCOLHA UMA OPÇÃO: ");
                esc = int.Parse(Console.ReadLine());

                switch (esc)
                {
                    case 1:


                        Console.Write("Informe o número do quarto desejado [0-9]: ");
                        int numQuarto = int.Parse(Console.ReadLine());
                        if (quartos[numQuarto].Alugado == false)
                        {
                            Console.Write("Informe o seu nome: ");
                            string nome = Console.ReadLine();
                            Console.Write("Informe o seu email: ");
                            string email = Console.ReadLine();
                            quartos[numQuarto].AlugarQuarto(numQuarto, nome, email);
                            Console.WriteLine("Quarto alugado com sucesso!");

                        }
                        else
                        {
                            Console.WriteLine("Quarto já está alugado, escolha uma outra opção!");

                        }
                        break;
                    case 2:
                        Console.WriteLine("Estes são os quartos disponíveis: ");
                        for (int i = 0; i < qtdQuartos; i++)
                        {
                            if (quartos[i].Alugado == false)
                            {

                                Console.WriteLine($"Quarto {i} - DISPONIVEL");

                            }
                            else
                            {
                                Console.WriteLine($"Quarto {i} - ALUGADO");
                            }

                        }




                        break;

                    case 3:
                        Console.WriteLine("Quartos ocupados: ");

                        for (int i = 0; i < qtdQuartos; i++)
                        {
                            if (quartos[i].Alugado == true)
                            {

                                Console.WriteLine($"{i}: {quartos[i].Nome}, {quartos[i].Email}");

                            }
                        }
                        break;
                    case 4:

                        Console.WriteLine("Até a próxima! :)");
                        cont = 0;

                        break;

                }








            } while (cont != 0) ;










        }    
    }

    
}