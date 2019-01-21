using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WattRand.BusinessLogic
{
    public class ControlElement
    {
        public ControlElement(DateTime date, double inValue, double outValue)
        {
            Date = date;
            InValue = inValue;
            OutValue = outValue;
        }
        public DateTime Date { get; set; }
        public double InValue { get; set; }
        public double OutValue { get; set; }
    }
}
