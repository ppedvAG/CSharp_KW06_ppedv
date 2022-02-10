using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul008_Virtual
{
    public class Fahrzeug
    {
        public int PS { get; set; }

        public virtual string WasBinIch()
        {
            return "Ich bin ein Fahrzeug";
        }
    }

    public class Auto : Fahrzeug
    {
        public new string WasBinIch()
        {
            return "Ich bin ein Auto";
        }
    }

    public class ElectroCar : Auto
    {

        //Man kann höchtens noch eine überladene Methode hinzufügen 
        public string WasBinIch(string str)
        {
            return "Ich bin ein Elektro-Auto";
        }
    }





    //Sealed richtig im Einsatz
    public sealed class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }

    //BEI VERERBUNG VON SINGLETON WÜRDE ES HIER ZU EINEM FEHLER KOMMEN
    //public class MyHackedSingletonClass : Singleton
    //{

    //}
}
