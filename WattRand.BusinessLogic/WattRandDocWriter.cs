using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace WattRand.BusinessLogic
{
    public class WattRandDOCWriter
    {
        private const string INVALUE_HEADER = "Dentro";
        private const string OUTVALUE_HEADER = "Fuori";
        public List<ControlElement> Elements { get; private set; }
        public WattRandDOCWriter(List<ControlElement> elements)
        {
            Elements = elements;
        }

        public void SaveToFile(string fileName, string templateFile)
        {
            DocX doc = DocX.Load(templateFile);
            var tbs = doc.Tables;
            var uno = tbs[0];
        }
    }
}
