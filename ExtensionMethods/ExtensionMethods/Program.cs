using System;
using ExtensionMethods.Extension;



namespace ExtensionMethods
{
    class Program
    {

        static void Main(string[] args)
        {


            
            DateTime dt = new DateTime(2023, 11, 15, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
            

            string s1 = "Good mornig dear students!";

            Console.WriteLine(s1.Cut(10));

          




        }


    }


}