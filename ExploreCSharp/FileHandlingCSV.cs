using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;


namespace ExploreCSharp
{
    public class ItemDetails
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }

    }
    public class FileHandlingCSV
    {
        //public string filePath = "C:/Ranjith/Learnings/Projects/itemdetails.csv";

        List<ItemDetails> items = new List<ItemDetails>
        {
            new ItemDetails { ID=24, ItemName="Laptop", ItemPrice=76558},
            new ItemDetails { ID=25, ItemName="Chockpiece", ItemPrice=34.5},
            new ItemDetails { ID=26, ItemName="Pencil", ItemPrice=45},
            new ItemDetails { ID=27, ItemName="Mouse", ItemPrice=345},
            new ItemDetails { ID=28, ItemName="Keyboard", ItemPrice=567}
        };

        public void ReadContentFromCSV(string filePath)
        {
            
            Console.WriteLine($"File path: {filePath}");
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

        public void ReadCSVContentLineByLine(string filePath, string name=null)
        {
            try
            {
                if(File.Exists(filePath))
                {
                    var configItems = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        HasHeaderRecord = false
                    };

                    using (StreamReader reader = new StreamReader(filePath))
                    using (CsvReader readcsv = new CsvReader(reader, configItems))
                    {
                        IEnumerable<ItemDetails> iteminfo = readcsv.GetRecords<ItemDetails>();
                        foreach(ItemDetails item in iteminfo)
                        {
                            if(name!=null)
                            {
                                if(item.ItemName.ToUpper()==name.ToUpper())
                                {
                                    Console.WriteLine("\nSearch Record found");
                                    Console.WriteLine($"ID: {item.ID}, Name: {item.ItemName}, Price: {item.ItemPrice}");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"ID: {item.ID}, Name: {item.ItemName}, Price: {item.ItemPrice}");
                            }
                        }
                    }
                }
                else
                {
                    throw new Exception($"Given file is not present in the path: {filePath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to fetch the value: {ex.Message}");
            }
            
        }

        public void WriteContentIntoCSV(string filePath)
        {
            var confgItems = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false
            };

            using (var streamwriter = new StreamWriter(filePath, true))
            using (var writer = new CsvWriter(streamwriter, confgItems))
            {
                writer.WriteRecords(items);
            }
            Console.WriteLine("Data written to CSV") ;
        }

    }
}
