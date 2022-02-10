using System;
using Modul007_Samples; //voriges Beispiel 
 

namespace Modul008_Vererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensch jungerMensch = new Mensch("Peter", "Muster", "Frankfurt", DateTime.Now);

            Mensch erwachsenderMensch = new Mensch("Otto", "Walkes", "Friesland", new DateTime(1962, 5, 5), new DateTime(1968, 5, 5));

            
            Console.WriteLine(erwachsenderMensch.ToString());



            Employee employee = new("Heidi", "Schweiz", "Berg", new DateTime(1981, 6, 6), 10, "ohne Arbeit");
            employee.Fortbewegung();
        }
    }

    //Vererbung
    public class Mensch : Lebewesen //referenziert mit Modul007_Samples;
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Wohnort { private set; get; }



        //DateTime? -> DateTime kann hier null zugeordnet bekommen und es kann auf Null geprüft werden
        public DateTime? ErsterSchultag { get; set; } = null;

        //Menschen ohne Schulbildung oder zu jung für Schule
        public Mensch(string vorname, string nachname, string wohnort, DateTime birthday)
            : base("Mensch", birthday)
        {
            Vorname = vorname;
            Nachname = nachname;
            Wohnort = wohnort;
        }


        //Für Menschen die der Schule waren
        public Mensch(string vorname, string nachname, string wohnort, DateTime birthday, DateTime ersterSchulungsTag)
            : base("Mensch", birthday)
        {
            Vorname = vorname;
            Nachname = nachname;
            Wohnort = wohnort;
            ErsterSchultag = ersterSchulungsTag;
        }

        public void Lesen()
        {
            //Kann Lesen 
        }

        public override string ToString()
        {
            return $"Der Mensch {Vorname} {Nachname} ist {AlterInJahren} und wohnt in {Wohnort}";
        }

        public sealed override void Fortbewegung()
        {
            //base.Fortbewegung(); -> optional kann man die Basis-Methode zusätzlich aufrufen 
            Console.WriteLine("Der Mensch läuft auf zwei Beine");
        }

        public new void Kommunikation()
        {
            Console.WriteLine("Der Mensch spricht"); 
        }
    }

    public class Employee : Mensch //public, internal ... 
    {
        public Employee(string vorname, string nachname, string wohnort, DateTime birthday, int gehalt, string job) 
            : base(vorname, nachname, wohnort, birthday)
        {
            Gehalt = gehalt;
            Job = job;
        }

        public int Gehalt { get; set; }
        public string Job { get; set; }


        public override void Fortbewegung() //Kann nicht überschrieben werden, Methode 'Fortbewegung' in Mensch wird mit sealed markiert
        {
            Console.WriteLine("Die Person ist Pilot eines Flugzeuges und hat das Laufen verlernt ");
        }

        public override void Kommunikation() //Methode 'Mensch.Kommunikation wurde nicht mit virtual, abstract oder override markiert  
        {
            base.Kommunikation();
        }


    }
}
