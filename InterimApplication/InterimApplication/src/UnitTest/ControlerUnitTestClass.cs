using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

using Controler;
using Model;

namespace UnitTest
{
    public static class ControlerCustomerCorporationsUnitTestClass
    {
        public static ControlerEntreprisesClientes cC = new ControlerEntreprisesClientes();

        public static bool TestChercherEntreprise()
        {
            Console.WriteLine("Testing Shearch Customers in the XML file...");
            List<EntrepriseCliente> myList = cC.chercher("Dassault System");
            foreach (EntrepriseCliente item in myList)
            {
                Console.WriteLine(item.ToString());
            }
            return (myList.Contains(new EntrepriseCliente("Dassault System", "10 rue Marcel Dassault, Velizy-Villacoublay", "712 042 456 00111")) ? true : false);
        }

        public static bool TestAjouterEntreprise()
        {
            Console.WriteLine("Testing Add a Customers in the XML file...");
            return (cC.ajouter(new EntrepriseCliente("Test Companie", "2 Street Top of The World", "869 201 256 78562")) ? true : false);
        }

        public static bool TestListerEntreprise()
        {
            Console.WriteLine("Testing List Customers in the XML file...");
            List<EntrepriseCliente> myList = cC.lister();
            foreach (EntrepriseCliente item in myList)
            {
                Console.WriteLine(item.ToString());
            }
            return true;
        }

        public static bool TestSupprimerEntreprise()
        {
            Console.WriteLine("Testing Delete a Customer in the XML file...");
            cC.supprimer(new EntrepriseCliente("Test Companie", "2 Street Top of The World", "869 201 256 78562"));
            List<EntrepriseCliente> myList = cC.lister();
            if (myList.Contains(new EntrepriseCliente("Test Companie", "2 Street Top of The World", "869 201 256 78562")))
            {
                return false;
            }
            return true;
        }
    }

    public static class ControlerEmployeTestClass
    {

    }
}
