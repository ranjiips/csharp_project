using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Data;
using System.IO;


namespace ExploreCSharp
{
    //public class ItemDetailInfo
    //{
    //    public string ID { get; set; }
    //    public string ItemName { get; set; }
    //    public double ItemPrice {  get; set; }  
    //}
    public class FileHandlingExcel
    {
        string path = "";
        _Application excel = new _Excel.Application();        
        Workbook wb;
        Worksheet ws;
        public FileHandlingExcel(string path, int sheet) 
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        List<ItemDetails> items = new List<ItemDetails>()
        {
            new ItemDetails {ID=22, ItemName="Test", ItemPrice=98},
            new ItemDetails {ID=23, ItemName="Test1", ItemPrice=66}
        };

        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
                return ws.Cells[i, j].Value2;
            else
                return "";
        }

        public void ReadGivenCell(string cell)
        {
            string celldata = "" + ws.Range[cell].Value;
            Console.WriteLine($"Value in the cell {cell} is: {celldata}");
        }
        
        public void ReadCellRange()
        {
            var result = ReadExcelFile();
            foreach (var cell in result)
            {
                foreach (var i in cell)
                {
                    Console.Write(i+"\t");
                }
                Console.WriteLine();
            }
        }

        public List<List<string>> ReadExcelFile()
        {
            var cells = ws.get_Range("A1", "B15");

            return cells.Rows.Cast<_Excel.Range>().AsParallel().Select(row =>
            {
                return row.Cells.Cast<_Excel.Range>().Select(cell =>
                {
                    var cellContent = cell.Value2;
                    return (cellContent == null) ? String.Empty : cellContent.ToString();
                }).Cast<string>().ToList();
            }).ToList();
        }

        public void WriteGivenCell(string cell, string celltext)
        {
            ws.Range[cell].Value = celltext;
        }

        public void WriteGivenCellRange(string cellRange, string celltext)
        {
            ws.Range[cellRange].Value = "SampleTexts";
        }

        public void WriteMulitpleCells()
        {
            string[] name = { "Car", "Bus", "Lorry", "Truck", "Cart" };
            for (int i = 0; i < name.Length; i++)
            {
                ws.Range["B"+(2+i)].Value = name[i];
            }
        }

        public void SaveWorkboox()
        {
            wb.SaveAs2("C:\\Ranjith\\Learnings\\Projects\\itemdetails.xlsx");
        }
    }
}
