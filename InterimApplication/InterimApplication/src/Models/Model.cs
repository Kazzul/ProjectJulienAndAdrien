/*  Nous choisissons de définir des structures pour le modèle pour que la fonction equal renvoie à la fonction "ValueEqual" et non la fonction "ReferenceEqual"
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

        public string Entreprise {
         get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }
        public string Adresse 
        {
            get { return adresse; }
            set
            {
                adresse = value;
            }
        }
        public string Siret 
        { 
            get { return numSiret; } set { numSiret = value; } 
        }

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