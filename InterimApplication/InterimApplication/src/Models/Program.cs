using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterimApplication
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>

        [STAThread]
        static void Main()
        {

            #region Testing Application Managment Before Launching Views
                Console.WriteLine("#############################################################");
                Console.WriteLine("=>" + UnitTest.ControlerUnitTestClass.TestChercherEntreprise());
                Console.WriteLine("=>" + UnitTest.ControlerUnitTestClass.TestAjouterEntreprise());
                Console.WriteLine("=>" + UnitTest.ControlerUnitTestClass.TestListerEntreprise());
                Console.WriteLine("#############################################################");
            #endregion

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainInterimApp());
        }
    }
}
