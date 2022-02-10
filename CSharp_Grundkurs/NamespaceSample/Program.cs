using System;

using NamespaceSample.ErstesNamespace;
using NamespaceSample.ViertesNamesspace;
using NamespaceSample.ZweitesNamespace;

using First = NamespaceSample.ErstesNamespace; //Alias
using Second = NamespaceSample.ZweitesNamespace;

namespace NamespaceSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zugriff auf eine Klasse mit Namespace-Angabe 
            ErstesNamespace.MeineKlasse meineKlasse1 = new ErstesNamespace.MeineKlasse();
            NamespaceSample.ZweitesNamespace.MeineKlasse meineKlasse2 = new ZweitesNamespace.MeineKlasse();

            //Verwenden von Aliasen
            First.MeineKlasse meineKlasse3 = new First.MeineKlasse();
            Second.MeineKlasse meineKlasse4 = new Second.MeineKlasse();

            MyClass myClass = new MyClass(); // using NamespaceSample.ViertesNamesspace;

        }
    }
}

namespace AppName.DataAccess
{
    // Klassendefinitionen -> Repository Pattern / UnitOfWork Pattern
}

namespace AppName.DataAccess.Entites
{
    //Entities oder POCO Objects
}
