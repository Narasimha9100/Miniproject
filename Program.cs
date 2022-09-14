using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

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

                if (!(query.ToLower().Contains("continent")) || (!(query.Contains("="))))
                {
                    Console.WriteLine("Incorrect query");
                }
                else
                {
                    DataTable datatable = new DataTable();
                    StreamReader streamreader = new StreamReader(@"D:\Travel Agency Offers.tsv");
                    char delimiter = '\t' ; 
                    string[] columnheaders = streamreader.ReadLine().Split(delimiter);
                    foreach (string columnheader in columnheaders)
                    {
                        datatable.Columns.Add(columnheader); // I've added the column headers here.
                    }


                    while (streamreader.Peek() > 0)
                    {
                        DataRow datarow = datatable.NewRow();
                        datarow.ItemArray = streamreader.ReadLine().Split(delimiter);
                        datatable.Rows.Add(datarow);
                    }

                    if (datatable.Rows.Count > 1)
                    {

                        DataView dv = datatable.DefaultView;
                        if (!string.IsNullOrEmpty(continent))
                        {
                            dv.RowFilter = "Continent = '" + continent + "'";
                            if (dv.Count != 0)
                            {
                                Console.WriteLine("Results for Continent={0}({1})", continent, dv.Count);
                                Console.WriteLine();
                                Console.WriteLine();
                                DataTable filtercontinent = dv.ToTable();
                                foreach (DataRow dr in filtercontinent.Rows)
                                {
                                    Console.WriteLine("Continent=" + dr[0]);
                                    Console.WriteLine("Country:" + dr[1]);
                                    Console.WriteLine("City:" + dr[2]);
                                    Console.WriteLine("Hotel:" + dr[3]);
                                    Console.WriteLine("Stars:" + dr[4]);
                                    Console.WriteLine("Price:" + dr[7]);
                                    Console.WriteLine("_____________________________________________________________________________________________________________________");
                                }
                            }
                            else
                            {

                                Console.WriteLine("No record found");
                            }
                        }
                       
                    }

                        Console.ReadLine();
                }


               
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
