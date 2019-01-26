using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WattRand.BusinessLogic
{
    public class WattRandManager
    {
        public List<ControlElement> Elements { get; set; }

        public void Elaborate(string filePath)
        {
            WattRandExecutor executor = new WattRandExecutor(Elements);
            List<ControlElement> results = executor.Run();
            WattRandXLSWriter wr = new WattRandXLSWriter(results);
            wr.SaveToFile(filePath);

            //WattRandDOCWriter wrd = new WattRandDOCWriter(results);
            //wrd.SaveToFile(filePath, "C:\\Users\\Tomoki\\Documents\\Visual Studio 2015\\Projects\\WattRand\\(Passo2)Registro-letture-contatori-Test.docx");
        }

        public void Save()
        {

        }

    }
}
