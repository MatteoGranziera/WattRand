using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WattRand.BusinessLogic
{
    public class CellCursor
    {
        public string Column { get; set; }
        public int Row { get; set; }
        public string Cell { get { return String.Format("{0}{1}", Column, Row); } set { ParseCell(value); } }

        private void ParseCell(string input)
        {
            Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
            Match result = re.Match(input);

            Column = result.Groups[1].Value;
            Row = int.Parse(result.Groups[2].Value);
        }

        public void MoveColumn(int number = 1)
        {
            for (int i = 0; i < number; i++)
            {
                StringBuilder build = new StringBuilder(Column);
                bool ok = false;
                int index = 0;
                while (!ok)
                {
                    if (index > build.Length - 1)
                    {
                        build = new StringBuilder(string.Format("{0}{1}", 'A', build));
                        ok = true;
                    }                   
                    else if (build[index] == 'Z')
                    {
                        build[index] = 'A';
                        index++;
                    }
                    else
                    {
                        build[index]++;
                        ok = true;
                    }
                }
                Column = build.ToString();
            }
        }

        public void MoveRow(int number = 1)
        {
            Row += number;
        }
    }
}
