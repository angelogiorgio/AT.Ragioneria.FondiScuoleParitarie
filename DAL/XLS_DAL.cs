using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Office.Interop.Excel;

namespace AT.Ragioneria.FondiScuoleParitarie.DAL
{
    public class XLS_DAL
    {
        private string _path = string.Empty;

        private Workbook _workBook = null;


        public XLS_DAL(string path)
        {
            Application oExcel = new Application();

            this._path = path;

            this._workBook = oExcel.Workbooks.Open(path);

            //this.ParseSheet();


        }

        public List<List<object>> ParseSheet(int indexSheet, int indexRowInit, int indexColumnInit, int indexColumnEnd, int endRow)
        {
            string ExcelWorkbookname = this._workBook.Name;

            List<List<object>> records = new List<List<object>>();

            // statement get the worksheet count  
            int worksheetcount = this._workBook.Worksheets.Count;

            Worksheet wks = this._workBook.Worksheets[indexSheet];

            // statement get the firstworksheetname  

            string firstworksheetname = wks.Name;

            List<object> rowsLst = new List<object>();

            for(int rowIndex= indexRowInit; rowIndex <= endRow; rowIndex++)
            {
                List<object> record = new List<object>();

                for (int columnIndex = indexColumnInit; columnIndex <= indexColumnEnd; columnIndex++)
                {
                    //statement get the first cell value                      
                    record.Add(((Range)wks.Cells[rowIndex, columnIndex]).Value);
                }

                records.Add(record);

            }

            return records;
        }
    }
}