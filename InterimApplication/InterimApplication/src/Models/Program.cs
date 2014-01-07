using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using InterimApplication.src.Views;

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
                Console.WriteLine("=>" + UnitTest.ControlerCustomerCorporationsUnitTestClass.TestChercherEntreprise());
                Console.WriteLine("=>" + UnitTest.ControlerCustomerCorporationsUnitTestClass.TestAjouterEntreprise());
                Console.WriteLine("=>" + UnitTest.ControlerCustomerCorporationsUnitTestClass.TestListerEntreprise());
                //Console.WriteLine("=>" + UnitTest.ControlerCustomerCorporationsUnitTestClass.TestSupprimerEntreprise());
                Console.WriteLine("#############################################################");
            #endregion

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainInterimApp());
        }
    }
}
