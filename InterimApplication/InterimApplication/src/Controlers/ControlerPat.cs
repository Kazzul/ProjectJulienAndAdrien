
using System.Collections.Generic;

using System.Xml.Linq;

namespace Controler
{
    public abstract class ControlerPattern <T>{

        abstract public List<T> lister();

        abstract public List<T> chercher(string o);

        abstract public bool ajouter(T o);

        abstract public bool supprimer(T o);

        abstract public bool modifier(T oldObject, T newObject);

        abstract protected XElement createElement(T toXML);

        abstract public T generateElement(XElement e);
    }


}