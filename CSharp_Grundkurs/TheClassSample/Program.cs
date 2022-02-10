using System;

namespace TheClassSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            //Properties / Fields in einer Klasse
            Lebewesen lebewesen = new Lebewesen();
            lebewesen.Bezeichnung = "Harry Weinwurft";
            lebewesen.Lieblingsnahrung = "Lassagne";
            lebewesen.Birthday = new DateTime(1987, 8, 12);
            //lebewesen.AlterInJahren = 123; AlterInJahre ist readonly 
            Console.WriteLine($"Alter in Jahren: {lebewesen.AlterInJahren}");


            //Wie wird aus einer Klasse ein Object 

            //Deklaration einer Klasse
            Lebewesen lebewesen1;

            lebewesen1 = new Lebewesen();   // = new  -> Instanziierung 
                                            // Lebewesen(); -> Konstrukturaufruf 

            //Achtung! Wenn die Klasse keine Konstruktor implementiert hat, wird beim Kompilieren ein Default-Konstruktor automatisch hinzugefügt
            //Daher kann ich die Klasse Lebewesen so instanziieren: lebewesen1 = new Lebewesen(); 


            //lebewesen2 enthält die selbe Speicheradresse wie lebewesen1
            Lebewesen lebewesen2 = lebewesen1;
            lebewesen2.Bezeichnung = "Dagobert Duck";

            //um die Werte nur zu kopieren, gibt es einen Kopier-Konstruktor
            Lebewesen lebewesen3 = new Lebewesen(lebewesen1);

            lebewesen3.Bezeichnung = "Gustav Gans";

            Lebewesen dasKind = lebewesen3.GebäreKind();

            //dasKind.Wohnort = "NY"; //private Set regeln nur die Zuweisung einer Property innherlab seiner Klasse 

        }
    }

    
    public class Lebewesen
    {
        #region Fields
        //Variablen (Fields) sind private
        private string bezeichnung = "Hugo"; //Hugo wäre ein Default-Wert
        private DateTime birthday;

        //public string Wohnort { private set; get; }
        #endregion


        #region Konstruktoren
        //ctor + tab + tab -> leeren Default-Konstruktor
        //Was muss bei einem Konstuktor achten? Konstruktor haben den selben NAmen wie die Klasse 
        
        public Lebewesen()
        {
            //name = "Otto Walkes"; falsch 
            //Bezeichnung = "Otto Walkes"; //richtiger Weg -> via Properties
            //Birthday = DateTime.Now; //Lebewese´n wird im Default gerade geboren
            //Wohnort = "Entenhausen";
        }

        //Werte-Konstruktor -> Initialisieren mit definierten Werten 
        public Lebewesen(string bezeichnung, DateTime birthday)
        {
            Bezeichnung = bezeichnung;
            Birthday = birthday;
        }

        //Kopier-Konstruktor
        public Lebewesen(Lebewesen lebewesen)
        {
            Bezeichnung = lebewesen.Bezeichnung;
            Birthday = lebewesen.Birthday;
        }
        #endregion

        #region Properties


        //Properties  -> Kapselung 
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
                if(!string.IsNullOrEmpty(value))
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



        public void SetName (string name)
        {
            this.bezeichnung = name;
        }

        public string GetName()
        {
            return this.bezeichnung;
        }
        public Lebewesen GebäreKind()
        {
            //Factory-Methode -> Gibt mir eine Objekt-Instant heraus

            return new Lebewesen(this.Bezeichnung, DateTime.Now);
        }
    }
}
