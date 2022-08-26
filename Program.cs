using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MiniProject
{
  
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string query = Console.ReadLine();
                char[] separator = new char[] { '=' };
                string[] values = query.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string indicator = values[0];
                string continent = values[1];

                if (!(query.ToLower().Contains("continent=")) || (!(query.Contains("="))))
                {
                    Console.WriteLine("Incorrect query");
                }


                String st = File.ReadAllText("D:\\Travel Agency Offers.tsv");
                Console.WriteLine(st);
            }

            catch(Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.Read();
        }
    }
}
