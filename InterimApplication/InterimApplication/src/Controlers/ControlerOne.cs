using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

using Model;
using Acthors;

namespace Controler
{
    
    public class ControlerEntreprisesClientes : ControlerPattern<EntrepriseCliente>
    {

        override public List<EntrepriseCliente> chercher(string name)
        {
            XElement doc = XElement.Load("../../res/EntreprisesClientes.xml");
            IEnumerable<EntrepriseCliente> entrList =
                from entr in doc.Elements()
                where entr.Element("Nom") != null && entr.Element("Nom").Value.Contains(name)
                select generateElement(entr);
            return entrList.ToList();
        }

        override public bool ajouter(EntrepriseCliente o) { 
            XElement doc = XElement.Load("../../res/EntreprisesClientes.xml");
            List<EntrepriseCliente> myList = this.chercher(o.nom);
            if (this.chercher(o.nom).Contains(o))
            {
                return false;
            }
            doc.Add(this.createElement(o));
            doc.Save("../../res/EntreprisesClientes.xml");
            return true;
        }

        override public List<EntrepriseCliente> lister() {
            XElement doc = XElement.Load("../../res/EntreprisesClientes.xml");
            IEnumerable<EntrepriseCliente> entrList =
                from entr in doc.Elements()
                where entr.Element("Nom") != null
                select new EntrepriseCliente(entr.Element("Nom").Value, entr.Element("Adresse").Value, entr.Element("NumSiret").Value);
            return entrList.ToList();
        }

        override public bool supprimer(EntrepriseCliente o) {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../res/EntreprisesClientes.xml");
            if (this.chercher(o.nom).Contains(o))
            {
                XmlNode node = doc.SelectSingleNode("/EntreprisesClientes/Entreprise[Nom='"+o.nom+"']");
                node.ParentNode.RemoveChild(node);
                doc.Save("../../res/EntreprisesClientes.xml");
                return true;
            }         
            return false;
        }

        override public bool modifier(EntrepriseCliente oldObject, EntrepriseCliente newObject) { throw new NotImplementedException(); }

        override protected XElement createElement(EntrepriseCliente o)
        {
            XElement nam = new XElement("Nom", o.nom);
            XElement add = new XElement("Adresse", o.adresse);
            XElement sir = new XElement("NumSiret", o.numSiret);

            return new XElement("Entreprise",nam,add,sir);
        }

        public override EntrepriseCliente generateElement(XElement e)
        {
            return new EntrepriseCliente(e.Element("Nom").Value, e.Element("Adresse").Value, e.Element("NumSiret").Value);
        }
    }

    public abstract class ControlerEmploye : ControlerPattern<PersonneEmployeInterim>
    {
        abstract override public List<PersonneEmployeInterim> lister();

        abstract override public List<PersonneEmployeInterim> chercher(string o);

        abstract override public bool ajouter(PersonneEmployeInterim o);

        abstract override public bool supprimer(PersonneEmployeInterim o);

        abstract override public bool modifier(PersonneEmployeInterim oldObject, PersonneEmployeInterim newObject);

        public abstract override PersonneEmployeInterim generateElement(XElement e);
    }

    
}
