//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ InterimApplication : Untitled
//  @ InterimApp : ControlerPattern.cs
//  @ 19/12/2013 : 19/12/2013
//  @ Julien : 
//
//
using System.Collections.Generic;

namespace ControlerPat
{
    public abstract class ControlerPattern {

        abstract public List<object> lister();

        abstract public bool chercher(object o);

        abstract public bool ajouter(object o);

        abstract public bool supprimer(object o);

        abstract public bool modifier(object oldObject, object newObject);
    }


}