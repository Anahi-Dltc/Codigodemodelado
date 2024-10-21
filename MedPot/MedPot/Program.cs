using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedPot
{
    static class Program
    {
        public static int cristal= 0;
        public static double potencia = 55;
        public static int porcentajet = 100;
        public static int atenuacion = 0; 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
