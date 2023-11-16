using System;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using LogAccess.Entities;








namespace LogAccess
{
    class Program
    {
        static void Main(string[] args) {
        
           
           HashSet<LogRecord> set = new HashSet<LogRecord>();
           Console.Write("Enter path file: ");
           string path = Console.ReadLine();

            


            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        
                        
                        string name = line[0];

                        DateTime moment = DateTime.Parse(line[1]);



                        set.Add(new LogRecord(name, moment));
                    }
                    Console.WriteLine("Total user: " + set.Count);


                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
          


            





        }
    }
}