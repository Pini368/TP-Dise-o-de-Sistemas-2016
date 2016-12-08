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

namespace CLogica.Gestores
{
    public class GestorDeEvaluacion
    {
        public Evaluacion getEvaluaciones(int idEvaluacion)
        {
            EvaluacionDAO cdatos = new EvaluacionDB();
            try
            {
                return cdatos.getEvaluaciones(idEvaluacion);
            }
            catch(Exception ex){
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
        public void exportarAExcel(Evaluacion ev, DataGridView TuDataGrid,FolderBrowserDialog ubicacion)

        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
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
            excel.Application.ActiveWorkbook.SaveCopyAs(archivo);
        }
    }
}
