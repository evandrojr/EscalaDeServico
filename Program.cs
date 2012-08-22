using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscalaDeServico
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            D D= new D();
            D.LoadConst();
            D.Calendario = new Calendario();
            D.Calendario.Load();
            D.F = new Funcionario();
            D.F.Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
