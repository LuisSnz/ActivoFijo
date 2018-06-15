using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Data;

namespace ActivoFijo.Clases
{
    class Excel
    {
        public static Hashtable myHashtable;
        public static string ruta;

        public static void GridViewExcel(DataGridView grd)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Process[] AllProcesses = Process.GetProcessesByName("excel");
                    myHashtable = new Hashtable();
                    int iCount = 0;

                    foreach (Process ExcelProcess in AllProcesses)
                    {
                        myHashtable.Add(ExcelProcess.Id, iCount);
                        iCount = iCount + 1;
                    }
                    Auxiliares.Cargando cargando = new Auxiliares.Cargando();
                    cargando.Show();
                    cargando.progressBar1.Maximum = grd.Rows.Count;
                    cargando.progressBar1.Value = 0;
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    for (int j = 0; j < grd.ColumnCount; j++)
                    {
                        hoja_trabajo.Cells[1, j + 1] = grd.Columns[j].HeaderText;
                    }
                    hoja_trabajo.Rows[1].Font.Bold = true;
                    hoja_trabajo.Rows[1].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    for (int i = 0; i < grd.Rows.Count; i++)
                    {
                        for (int j = 0; j < grd.Columns.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                        }
                        cargando.progressBar1.Value = cargando.progressBar1.Value + 1;
                    }
                    hoja_trabajo.Columns.AutoFit();
                    libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close();
                    aplicacion.Quit();
                    ruta = "\"" + fichero.FileName + "\"";
                    cargando.Close();
                    KillExcel();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        public static void KillExcel()
        {
            Process[] AllProcesses = Process.GetProcessesByName("excel");
            foreach (Process ExcelProcess in AllProcesses)
            {
                if (myHashtable.ContainsKey(ExcelProcess.Id) == false)
                    ExcelProcess.Kill();
            }

            AllProcesses = null;
            openExcel();
        }
        public static void openExcel()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "Excel.exe";
            startInfo.Arguments = ruta;
            Process.Start(startInfo);
        }





        public static void DSExcel(DataSet grd)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Process[] AllProcesses = Process.GetProcessesByName("excel");
                    myHashtable = new Hashtable();
                    int iCount = 0;

                    foreach (Process ExcelProcess in AllProcesses)
                    {
                        myHashtable.Add(ExcelProcess.Id, iCount);
                        iCount = iCount + 1;
                    }
                    Auxiliares.Cargando cargando = new Auxiliares.Cargando();
                    cargando.Show();
                    cargando.progressBar1.Maximum = grd.Tables[0].Rows.Count;
                    cargando.progressBar1.Value = 0;
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    for (int j = 0; j < grd.Tables[0].Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[1, j + 1] = grd.Tables[0].Columns[j].ColumnName;
                    }
                    for (int i = 0; i < grd.Tables[0].Rows.Count; i++)
                    {
                        for (int j = 0; j < grd.Tables[0].Columns.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 2, j + 1] = grd.Tables[0].Rows[i][j].ToString();
                        }
                        cargando.progressBar1.Value = cargando.progressBar1.Value + 1;
                    }
                    libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close();
                    aplicacion.Quit();
                    ruta = "\"" + fichero.FileName + "\"";
                    cargando.Close();
                    KillExcel();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }
    }
}
