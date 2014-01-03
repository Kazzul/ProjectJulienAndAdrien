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

/*  Nous choisissons de d�finir des structures pour le mod�le pour que la fonction equal renvoie � la fonction "ValueEqual" et non la fonction "ReferenceEqual"
 *
 * */

namespace Model
{
    public struct Competence
    {
        private string description;
        private int niveaus;
        private string nom;
    }


    public struct EntrepriseCliente
    {
        public string nom;
        public string adresse;
        public string numSiret;

        #region Constructeur
        public EntrepriseCliente(string n, string ad, string num){nom = n; adresse = ad; numSiret = num; }
        #endregion

        public override string ToString()
        {
            return nom + ": " + adresse + ": " + numSiret;
        }
    }

    public struct Facturation
    {
        private int cout;
    }

    public struct Mission
    {
        private string description;
        private System.Globalization.Calendar beginDate;
        private System.Globalization.Calendar endDate;
    }
}