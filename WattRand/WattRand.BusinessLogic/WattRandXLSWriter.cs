using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.Globalization;

namespace WattRand.BusinessLogic
{
    public class WattRandXLSWriter
    {
        private const string INVALUE_HEADER = "Dentro";
        private const string OUTVALUE_HEADER = "Fuori";
        public List<ControlElement> Elements { get; private set; }
        public WattRandXLSWriter(List<ControlElement> elements)
        {
            Elements = elements;
        }

        public void SaveToFile(string fileName)
        {
            XLWorkbook wb = new XLWorkbook();
            var ws = wb.AddWorksheet("Valori");
            var startCell = ws.Cell("A1");
            var firstEl = Elements.First();
            var cursor = new CellCursor();
            cursor.Cell = "A2";
            Elements.Remove(firstEl);
            

            if (DateTime.DaysInMonth(firstEl.Date.Year, firstEl.Date.Month) == firstEl.Date.Day)
            {
                string startMonthName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
                    firstEl.Date.AddMonths(1).ToString("MMMM", CultureInfo.CreateSpecificCulture("it")));
                AddHeaderMonth(startCell, startMonthName);
                WriteRow(ws.Cell(cursor.Cell), 0, firstEl.InValue, firstEl.OutValue);
                cursor.MoveRow();
            }
            else
            {
                string startMonthName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
                    firstEl.Date.ToString("MMMM", CultureInfo.CreateSpecificCulture("it")));
                AddHeaderMonth(startCell, startMonthName);

                for(int i = 0; i < firstEl.Date.Day;i++)
                {
                    WriteRow(ws.Cell(cursor.Cell), i, 0, 0);
                    cursor.MoveRow();
                }

                WriteRow(ws.Cell(cursor.Cell), firstEl.Date.Day, firstEl.InValue, firstEl.OutValue);
                cursor.MoveRow();
            }

            foreach (var el in Elements)
            {
                WriteRow(ws.Cell(cursor.Cell), el.Date.Day, el.InValue, el.OutValue);
                cursor.MoveRow();
                if (DateTime.DaysInMonth(el.Date.Year, el.Date.Month) == el.Date.Day)
                {
                    cursor.Cell = string.Format("{0}{1}", cursor.Column, 1);
                    cursor.MoveColumn(4);
                    string startMonthName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
                        el.Date.AddMonths(1).ToString("MMMM", CultureInfo.CreateSpecificCulture("it")));
                    AddHeaderMonth(ws.Cell(cursor.Cell), startMonthName);
                    cursor.MoveRow();
                    WriteRow(ws.Cell(cursor.Cell), 0, el.InValue, el.OutValue);
                    cursor.MoveRow();
                }
            }

            wb.SaveAs(fileName);
        }

        private void AddHeaderMonth(IXLCell startCell, string monthName)
        {
            startCell.DataType = XLDataType.Text;
            startCell.Value = monthName;

            startCell.CellRight().DataType = XLDataType.Text;
            startCell.CellRight().Value = INVALUE_HEADER;

            startCell.CellRight().CellRight().DataType = XLDataType.Text;
            startCell.CellRight().CellRight().Value = INVALUE_HEADER;
        }
        private void WriteRow(IXLCell startCell, int row, double inValue, double outValue)
        {
            startCell.DataType = XLDataType.Text;
            startCell.Value = row;

            startCell.CellRight().DataType = XLDataType.Text;
            if(inValue>0)
                startCell.CellRight().Value = inValue.ToString("0");


            startCell.CellRight().CellRight().DataType = XLDataType.Text;
            if (outValue > 0)
                startCell.CellRight().CellRight().Value = outValue.ToString("0");
        }
    }
}
