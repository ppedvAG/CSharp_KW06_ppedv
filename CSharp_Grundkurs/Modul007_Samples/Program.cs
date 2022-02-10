using System;
using System.Collections.Generic;

namespace Modul007_Samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lebewesen lebewesen;

            IList<Lebewesen> myGTAWorld = new List<Lebewesen>();
            
            List<Lebewesen> myGTA7World = new List<Lebewesen>();

            for (int i = 0; i < 50; i++)
            {
                lebewesen = new Lebewesen();
                myGTAWorld.Add(lebewesen);
            }

            
            Console.WriteLine(Lebewesen.AnzahlLebewesen);
            Lebewesen.ZeigeAnzahlLebewesen();

           
        }
    }


    public class Lebewesen
    {
        #region Fields
        //Variablen (Fields) sind private
        private string bezeichnung; //Hugo wäre ein Default-Wert
        private DateTime birthday;

        
        #endregion

        #region Konstruktoren
        //ctor + tab + tab -> leeren Default-Konstruktor
        //Was muss bei einem Konstuktor achten? Konstruktor haben den selben NAmen wie die Klasse 

        public Lebewesen()
        {
            //name = "Otto Walkes"; falsch 
            //Name = "Otto Walkes"; //richtiger Weg -> via Properties
            //Birthday = DateTime.Now; //Lebewese´n wird im Default gerade geboren
            //Wohnort = "Entenhausen";
            AnzahlLebewesen++;
        }


        //Dekonstruktor wird verwendet um ein Objekt sauber abzuarbeiten...bzw zu zerstören
        ~Lebewesen()
        {
            AnzahlLebewesen--;
        }

        //Werte-Konstruktor -> Initialisieren mit definierten Werten 
        public Lebewesen(string bezeichnung, DateTime birthday)
            :this()
        {
            Bezeichnung = bezeichnung;
            Birthday = birthday;
        }

        //Kopier-Konstruktor
        public Lebewesen(Lebewesen lebewesen)
            : this(lebewesen.Bezeichnung, lebewesen.Birthday)
        {
           
        }
        #endregion

        #region Properties
        //Properties
        public string Bezeichnung
        {
            get
            {
                return bezeichnung;
            }

            //Das Schlüsselwort VALUE beschreibt in einer Set-Methode den übergeben Wert 
            set
            {
                //wenn VALUE einen Wert hat, wird dieser auch zugewiesen 
                if (!string.IsNullOrEmpty(value))
                    bezeichnung = value;
            }
        }


        //Auto-Property -> sind aber zu normalen Properties erweiterbar.
        ////Achtung! Bei der Erweiterung der Property (siehe Name), muss eine private-Variable angelegt werden und innerhalb verwendet werden. 
        public string Lieblingsnahrung { get; set; } //Wo ist die dazugehörige Variable? Variable wird beim Kompilieren hinzugefügt

        public DateTime Birthday
        {
            get => birthday; //=> wird bei Einzeiler verwendet (Methoden oder bei get/set) 
            set => birthday = value;
        }

        public DateTime Birthday1
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        //Readonly 
        public int AlterInJahren
        {
            get
            {
                return ((DateTime.Now - this.Birthday).Days / 356);
            }
        }
        #endregion

        #region AntiBeispiele Get/Set Methoden
        public void SetName(string name)
        {
            this.bezeichnung = name;
        }

        public string GetName()
        {
            return this.bezeichnung;
        }
        #endregion



        #region Statische Member
        //STATISCHE Variablen und Methoden hängen an der Klasse selbst und nicht an instanziierten Objekten. Sie existieren demnach unabhängig von der Anzahl
        ///Objekte genau einmal. Der Aufruf erfolgt über den Klassenbezeichner.
        public static int AnzahlLebewesen { get; set; } = 0; 

        public static string ZeigeAnzahlLebewesen()
        {
            return $"Es gibt {AnzahlLebewesen} Lebewesen";
        }
        #endregion


        public void Atmen()
        {
        }

        public virtual void Fortbewegung()
        {
            Console.WriteLine($"{Bezeichnung} bewegt sich" );
        }

        public virtual void Kommunikation()
        {
            Console.WriteLine("undefinierte laute");
        }

        
        public Lebewesen GebäreKind()
        {
            //Factory-Methode -> Gibt mir eine Objekt-Instant heraus

            return new Lebewesen(this.Bezeichnung, DateTime.Now);
        }
    }
}


