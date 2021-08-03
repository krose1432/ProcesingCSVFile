using System;
using System.Collections.Generic;
using System.IO;

namespace ProcessingCSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> Sales2003 = new List<double>();
            List<int> Sales2004 = new List<int>();
            List<int> Sales2005 = new List<int>();
            double totalSales = 0;
            double sales2003 = 0;
            double sales2004 = 0;
            double sales2005 = 0;
            string salePrice;
            string year;

            //Reads in File
            string[] file = File.ReadAllLines("sales_data_sample (1).csv");
            for (int i = 0; i < file.Length; i++)
            {
                year = file[i].Split(',')[9];
                if (file[i].Contains("Shipped"))
                {
                    salePrice = file[i].Split(',')[2];
                    totalSales = totalSales + Convert.ToDouble(salePrice);
                }
                if (file[i].Contains("Shipped") && year == "2003")
                {
                    salePrice = file[i].Split(',')[2];
                    sales2003 = sales2003 + Convert.ToDouble(salePrice);
                    
                }
                if (file[i].Contains("Shipped") && year == ("2004"))
                {
                    salePrice = file[i].Split(',')[2];
                    sales2004 = sales2004 + Convert.ToDouble(salePrice);

                }
                if (file[i].Contains("Shipped") && year == ("2005"))
                {
                    salePrice = file[i].Split(',')[2];
                    sales2005 = sales2005 + Convert.ToDouble(salePrice);

                }
            }
            
            Console.WriteLine("The total amount of sales were " + totalSales.ToString("F2"));
            Console.WriteLine("The total amount of sales in 2003 was " + sales2003.ToString("F2"));
            Console.WriteLine("The total amount of sales in 2004 was " + sales2004.ToString("F2"));
            Console.WriteLine("The total amount of sales in 2005 was " + sales2005.ToString("F2"));
            double salesSum = sales2003 + sales2004 + sales2005;
            Console.WriteLine("Just to confirm, the sum of all three years are " + salesSum.ToString("F2"));

           

        }
    }
}
