using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDB;
using CDatos.ClasesDAO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace CLogica.Gestores
{
    public class GestorExcel
    {
        public void exportarAExcel2(Evaluacion ev, DataGridView TuDataGrid, FolderBrowserDialog ubicacion)

        {
            //Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();



            var excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add();
            int ColumnIndex = 0;
            foreach (DataGridViewColumn col in TuDataGrid.Columns)
            {
                ColumnIndex++;
                excel.Cells[1, ColumnIndex] = col.HeaderText;
            }
            int rowIndex = 0;
            foreach (DataGridViewRow row in TuDataGrid.Rows)
            {
                rowIndex++;
                ColumnIndex = 0;
                foreach (DataGridViewColumn col in TuDataGrid.Columns)
                {
                    ColumnIndex++;

                    excel.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;
                }
            }
            GestorDePuestos clogPues = new GestorDePuestos();
            Puesto puesto = clogPues.getPuestos(ev.id_puesto);
            string fecha = DateTime.Now.ToString("yyyy-M-dd-H-mm-");
            string funcion = puesto.nombre;
            string archivo = ubicacion.SelectedPath + "\\" + fecha + funcion + ".xlsx";
            Worksheet workSheet = excel.ActiveSheet;
            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
            workSheet.Columns[3].AutoFit();
            workSheet.Columns[4].AutoFit();
            workSheet.Columns[5].AutoFit();
            excel.Application.ActiveWorkbook.SaveCopyAs(archivo);
        }
        public void exportarAExcel(Evaluacion ev, DataGridView TuDataGrid, FolderBrowserDialog ubicacion)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            int ColumnIndex = 0;
            foreach (DataGridViewColumn col in TuDataGrid.Columns)
            {
                ColumnIndex++;
                xlApp.Cells[1, ColumnIndex] = col.HeaderText;
            }
            int rowIndex = 0;
            foreach (DataGridViewRow row in TuDataGrid.Rows)
            {
                rowIndex++;
                ColumnIndex = 0;
                foreach (DataGridViewColumn col in TuDataGrid.Columns)
                {
                    ColumnIndex++;

                    xlApp.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;
                }
            }

            GestorDePuestos clogPues = new GestorDePuestos();
            Puesto puesto = clogPues.getPuestos(ev.id_puesto);
            string fecha = DateTime.Now.ToString("yyyy-M-dd-H-mm-");
            string funcion = puesto.nombre;
            string archivo = ubicacion.SelectedPath + "\\" + fecha + funcion + ".xlsx";
            Worksheet workSheet = xlApp.ActiveSheet;
            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
            workSheet.Columns[3].AutoFit();
            workSheet.Columns[4].AutoFit();
            workSheet.Columns[5].AutoFit();
            xlWorkBook.SaveCopyAs(archivo);
            xlWorkBook.Close(false);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
