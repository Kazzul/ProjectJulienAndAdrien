//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ InterimApplication : Untitled
//  @ InterimApp : Competence.cs
//  @ 19/12/2013 : 19/12/2013
//  @ Julien : 
//
//

namespace Model
{
    public class Competence
    {
        private string description = null;
        private int niveaus;
        private string nom = null;
    }


    public class EntrepriseCliente
    {
        private string nom = null;
        private string adresse = null;
        private string numSiret = null;
    }

    public class Facturation
    {
        private int cout;
    }

    public class Mission
    {
        private string description = null;
        private System.Globalization.Calendar beginDate;
        private System.Globalization.Calendar endDate;
    }
}