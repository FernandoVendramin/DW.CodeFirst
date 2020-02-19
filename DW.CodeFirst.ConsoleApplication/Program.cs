using DW.CodeFirst.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.CodeFirst.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start *******************");

            Console.WriteLine("Inserting DimDate data... ");
            DimDateService.CreateDate();

            Console.WriteLine("Inserting DimTime data... ");
            DimTimeService.CreateDate();

            Console.WriteLine("Finish ******************");
            Console.ReadKey();
        }
    }
}
