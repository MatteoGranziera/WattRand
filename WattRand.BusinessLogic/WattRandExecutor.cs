using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WattRand.BusinessLogic
{
    public class WattRandExecutor
    {
        private IEnumerable<ControlElement> _elements;
        public int DatesDifference { get; private set; }
        public int ThresoldPart { get; private set; }
        public ControlElement StartElement { get; private set; }
        public List<ControlElement> Result { get; private set; }

        public WattRandExecutor(List<ControlElement> elements, int thresoldValue = 2)
        {
            var allElements = elements.OrderBy(e => e.Date).ToList();
            StartElement = allElements.First();
            Result = new List<ControlElement>();
            allElements.Remove(StartElement);
            ThresoldPart = thresoldValue;
            _elements = allElements;
        }
        public List<ControlElement> Run()
        {
            var beforeEl = StartElement;
            Result.Add(StartElement);

            foreach(var e in _elements)
            {
                Result.AddRange(GenerateRandomNumbers(beforeEl, e));
                Result.Add(e);
                beforeEl = e;
            }

            return Result;
        }

        public List<ControlElement> GenerateRandomNumbers(ControlElement start, ControlElement end)
        {
            Random rnd = new Random();
            List<ControlElement> results = new List<ControlElement>();

            //Get difference between dates
            TimeSpan span = end.Date.Subtract(start.Date);
            DatesDifference = (int)span.TotalDays;

            DateTime actualDate = start.Date;
            double actualIn = start.InValue;
            double actualOut = start.OutValue;

            //Calcolo il singolo incremento
            double inBaseIncrase = ((end.InValue - start.InValue) / DatesDifference);
            double outBaseIncrase = ((end.OutValue - start.OutValue) / DatesDifference);

            double inIncrase = inBaseIncrase / ThresoldPart;
            double outIncrase = outBaseIncrase / ThresoldPart;

            double substractIn = inIncrase / DatesDifference;
            double substractOut = outIncrase / DatesDifference;

            double startInRange = -1 * inIncrase;
            double startOutRange = -1 * outIncrase;
            double endInRange = inIncrase;
            double endOutRange = outIncrase;

            for (int i = 1; i < DatesDifference; i++)
            {
                int randomInIncrase = rnd.Next(Convert.ToInt32(startInRange), Convert.ToInt32(endInRange));
                int randomOutIncrase = rnd.Next(Convert.ToInt32(startOutRange), Convert.ToInt32(endOutRange));

                actualIn += inBaseIncrase + randomInIncrase;
                actualOut += outBaseIncrase + randomOutIncrase;
                actualDate = actualDate.AddDays(1);

                if (randomInIncrase < 0)
                    startInRange += substractIn;
                else
                    endInRange -= substractIn;

                if (randomOutIncrase < 0)
                    startOutRange += substractOut;
                else
                    endOutRange -= substractOut;
                results.Add(new ControlElement(actualDate, actualIn, actualOut));
            }

            return results;
            
        }
        
    }
}
