using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP_RC_UI.Properties;

namespace LP_RC_UI
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

            if (Settings.Default.SelectedForm == "Form1")
            { Application.Run(new Form1()); }

            if (Settings.Default.SelectedForm == "Form2")
            { Application.Run(new Form2()); }

            if (Settings.Default.SelectedForm == "Form3")
            { Application.Run(new Form3()); }

            if (Settings.Default.SelectedForm == "Form4")
            { Application.Run(new Form4()); }

            if (Settings.Default.SelectedForm == "Form5")
            { Application.Run(new Form5()); }

        }
    }
}
