using DW.CodeFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.CodeFirst.Data.Services
{
    public class DimDateService
    {
        public static void CreateDate()
        {
            Context dataContext = new Context();

            if (dataContext.DimDate.Count() == 0)
            {
                DateTime startDate = new DateTime(2019, 01, 01);
                DateTime endDate = new DateTime(2020, 12, 31);

                List<DimDate> dimDates = new List<DimDate>();
                for (DateTime date = startDate; date < endDate; date = date.AddDays(1))
                {
                    string dimdate = date.ToString("yyyyMMdd");
                    int dimDateKey = int.Parse(dimdate);

                    dimDates.Add(new DimDate
                    {
                        DimDateKey = dimDateKey,
                        FullDate = date,
                        Day = date.Day,
                        Month = date.Month,
                        MonthName = date.ToString("MMMM"),
                        Year = date.Year
                    });
                }

                dataContext.DimDate.AddRange(dimDates);
                dataContext.SaveChanges();
            }
        }
    }
}
