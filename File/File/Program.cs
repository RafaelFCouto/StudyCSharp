using System;
using System.IO;
using System.Collections.Generic;



namespace FileCourse
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            string sourcePath = @"C:\Users\ya079936\temp\files\file1.txt";

            string targetPath = @"C:\Users\ya079936\temp\files\file2.txt";

            string pathSw = @"C:\Users\ya079936\temp\files\YA-G01R01-DESEMB_FORMEL_D_01.txt";

            string pathPdf = @"C:\Users\ya079936\temp\files\teste.pdf";


            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(pathPdf);

                
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                

                
            }
            catch (IOException e) {

                Console.WriteLine("An error occurred: "+ e.Message);
            }

            


            string path = @"C:\Users\ya079936\temp\files\file1.txt";

            FileStream fs = null;

            StreamReader sr = null;

            try
            {



                sr = File.OpenText(path);


                while (!sr.EndOfStream)
                {
                    

                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                }
                

            }
            catch (IOException e)
            {

                Console.WriteLine("An error accured: " + e.Message);

            }
            finally {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
 
            
            }

           

            string path = @"C:\Users\ya079936\temp\files\file1.txt";


            try
            {


                using (StreamReader sr = File.OpenText(path))
                {

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }

                }


            }
            catch (IOException e)
            {


                Console.WriteLine("An error occurred: " + e.Message);

            }
            */

            string soucePath = @"C:\Users\ya079936\temp\files\file1.txt";
            string targetPath = @"C:\Users\ya079936\temp\files\file2.txt";

            try
            {
                /* 
                string[] lines = File.ReadAllLines(soucePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

                  
                
                var folder = Directory.EnumerateDirectories(soucePath, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FOLDERS:");
                foreach (string item in folder)
                {
                    Console.WriteLine(item);
                }

                var files = Directory.EnumerateFiles(soucePath, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FILES:");
                foreach (string item in files)  
                {
                    Console.WriteLine(item);
                }

                Directory.CreateDirectory(soucePath + @"\newfolder");
                */

                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("GetDirectoryName: "+ Path.GetDirectoryName(soucePath));
                Console.WriteLine("GetFileName: " + Path.GetFileName(soucePath));
                Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(soucePath));
                Console.WriteLine("GetFileExtension: "+Path.GetExtension(soucePath));
                Console.WriteLine("GetFullPath: "+Path.GetFullPath(soucePath));
                Console.WriteLine("GetTempPath: "+Path.GetTempPath());



            }
            catch (IOException e)
            {


                Console.WriteLine("An error occurred: " + e.Message);

            }









        }
    }
}