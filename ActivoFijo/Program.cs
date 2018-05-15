using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login lg = new Login();
            lg.ShowDialog();
            if (lg.DialogResult == DialogResult.OK)
            {
                //Esto junto con el Metodo "Main" lo traen por defecto           
                Application.Run(new Inicio());
            }
            //Application.Run(new Inicio());
        }
    }
}
