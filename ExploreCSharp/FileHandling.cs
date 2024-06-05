using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;


namespace ExploreCSharp
{
    public class FileHandling
    {
        public void ReadContentFromCSV()
        {
            string filePath = "C:/Ranjith/Learnings/Projects/itemdetails.csv";
            using (var reader = new StreamReader(filePath))
            {
                // Read the rest of the file
                while (!reader.EndOfStream)
                {
                    // Read the first line of the file
                    var line = reader.ReadLine();
                    // Split the data line into an array of values
                    var values = line.Split(',');
                    foreach (var value in values)
                    {
                        Console.Write(value + " \t ");
                    }
                    Console.WriteLine();
                }                
            }
        }

        public void ReadContentFromCSVUsingLinq()
        {
            StreamReader reader = null;
            try
            {
                //file path
                string filepath = "C:/Ranjith/Learnings/Projects/itemdetails.csv";
                //open the file
                using (reader = new StreamReader(filepath))
                {
                    while (!reader.EndOfStream)
                    {
                        //read the line 1 by 1
                        var line = reader.ReadLine();
                        //split the content using the delimeters
                        var values = line.Split(",");
                        //print it
                        foreach (var val in values)
                        {
                            Console.Write(val + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block");
                if(reader!= null)
                    reader.Dispose();
            }
        }


    }
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
    }

}
