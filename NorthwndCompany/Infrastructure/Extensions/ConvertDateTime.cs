using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Extensions
{
    public static class ConvertDateTime
    {
        public static string CovertDateTime(DateTime? date)
        {
            if (date != null) {
                var dt = date.Value;
                List<string> dm = dt.ToString().Split(".").ToList();
                string day;
                if (dm[0].Length == 1)
                    day = "0" + dm[0];
                else day = dm[0];

                string month = dm[1];
                int year = dt.Year;
                string inputDate = year + "-" + month + "-" + day;
                return inputDate;
            }
            else
                return null;
            
        }
    }
}
