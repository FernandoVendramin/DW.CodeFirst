using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.CodeFirst.Data.Models
{
    public class DimDate
    {
        public int DimDateKey { get; set; }
        public DateTime FullDate { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public string MonthName { get; set; }
        public int Year { get; set; }
    }
}
