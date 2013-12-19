using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterimApplication
{
    public abstract class Personne
    {
        private string nom = null;
        private string prenom = null;
    }

    public class PersonneEmployeInterim : Personne
    {
        private string age = null;
    }

    public class PersonneContact : Personne
    {
        private string mail;
        private string telephone;
    }
}
