using DW.CodeFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.CodeFirst.Data.Services
{
    public class DimTimeService
    {
        public static void CreateDate()
        {
            Context dataContext = new Context();

            if (dataContext.DimTime.Count() == 0)
            {
                DateTime startDate = new DateTime(2019, 01, 01, 0, 0, 0);
                DateTime endDate = startDate.AddDays(1).AddSeconds(-1);

                List<DimTime> dimTimes = new List<DimTime>();
                for (DateTime date = startDate; date <= endDate; date = date.AddSeconds(1))
                {
                    string dimtime = date.ToString("HHmmss");
                    int dimTimeKey = int.Parse(dimtime);

                    dimTimes.Add(new DimTime
                    {
                        DimTimeKey = dimTimeKey,
                        Hour = date.Hour,
                        Minute = date.Minute,
                        Second = date.Second
                    });
                }

                List<DimTime> newdimTimes = new List<DimTime>();
                foreach (var item in dimTimes)
                {
                    newdimTimes.Add(item);
                    if (newdimTimes.Count > 10000)
                    {
                        dataContext.DimTime.AddRange(newdimTimes);
                        dataContext.SaveChanges();

                        newdimTimes.Clear();
                    }
                }

                if (newdimTimes.Count > 0)
                {
                    dataContext.DimTime.AddRange(newdimTimes);
                    dataContext.SaveChanges();
                }
            }
        }
    }
}
