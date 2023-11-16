using System;
using System.Collections.Generic;
using System.IO;




namespace DictionaryStudy
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> votes = new Dictionary<string, int>();

            
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {

                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] qtdVotes = sr.ReadLine().Split(',');

                        string name = qtdVotes[0];
                        int vote = int.Parse(qtdVotes[1]);

                        if (votes.ContainsKey(name)) {
                            int i = int.Parse(qtdVotes[1]);
                            votes[name] += vote;
                        
                        }
                        else
                        {
                            
                            votes[name] = vote;
                        }
                        

                    }


                    foreach(var item in votes) {

                        Console.WriteLine(item.Key +": " + item.Value);


                    }
                }

            }

            catch (IOException e)
            {
                Console.WriteLine("Error: " +  e.Message);


            }





            /*
            Dictionary<string, string> cookies = new Dictionary<string, string>();


            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");


            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);


            Console.WriteLine("ALL COOKIES: ");

            foreach(KeyValuePair<string, string> kvp in cookies)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }
            */





        }
    }
}