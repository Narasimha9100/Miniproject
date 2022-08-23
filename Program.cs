using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MiniProject
{
    public class Headers
    {
        public string Continent { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Hotel { get; set; }
        public int Stars { get; set; }
        public int Date { get; set; }
        public int EndDate { get; set; }
        public int Price { get; set; }
        public int DiscountedPrice { get; set; }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello team");
            Console.ReadLine();
        }
    }
}
