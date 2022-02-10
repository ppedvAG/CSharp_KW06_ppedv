using System;

namespace Modul010_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchockerAchterbahn schockerAchterbahn = new SchockerAchterbahn();
            schockerAchterbahn.NumberOfToilets = 3;
            schockerAchterbahn.PlayMusic(); //Ist direkt aufrufbar 

            

            //Typprüfung: steckt IHaveToilets in der Klasse SchockerAchterbahn drin? 
            if (schockerAchterbahn is IHaveToilets toilets)
            {
               
                toilets.PlayMusic2();
                toilets.PlayMusic();
            }

            IHaveToilets haveToilets = new SchockerAchterbahn();
            haveToilets.PlayMusic();
            haveToilets.PlayMusic2();


            if (((IFSK18)schockerAchterbahn).AgeCheck(21))
            {
                Console.WriteLine("Wir fahren Achterbahn");
            }


        }
    }

    public class JahrmarktPlatz
    {
        public string Bezeichnung { get; set}
        public decimal Miete { get; set; }
        public double Fläche { get; set; }

        public DateTime OpenStoreAt{ get; set; }
        public DateTime CloseStoreAt { get; set; }
    }

    //public class FSK18Stand : JahrmarktPlatz
    //{
    //    public bool Alerskontroller(int alte)
    //    {
    //        return alte >= 18;
    //    }
    //}

    //public class HorrorKabinett : Fsk

    public interface IFSK18
    {
        bool AgeCheck(int alter)
        {
            return alter >= 18;
        }

        
    }

    public interface IHaveToilets
    {
        int NumberOfToilets { get; set; }

        void PlayMusic();

        void PlayMusic2()
        {
            Console.WriteLine("Alle verlassen aus guten Grund die Toiletten");
        }
    }

    public class AutoScooter : JahrmarktPlatz
    {
        public int AutoAnzahl { get; set; }
    }

    public class Karuseel : JahrmarktPlatz, IHaveToilets
    {
        public int Drehgeschwindkeit { get; set; }
        public int NumberOfToilets  { get; set; }

        public void PlayMusic()
        {
            Console.WriteLine("Biene Manja Song");
        }
    }

    public class HorrorKabinett : JahrmarktPlatz, IFSK18
    {
        public int SchauspielerAnzahl { get; set; }
    }

    public class SchockerAchterbahn : JahrmarktPlatz, IFSK18, IHaveToilets
    {
        public int Hoehe { get; set; }
        public int Geschwindigkeit { get; set; }
        public int NumberOfToilets { get; set; }

        public void PlayMusic()
        {
            Console.WriteLine("KISS Musik");
        }
    }

    public class KinderGeisterbahn : JahrmarktPlatz
    {
        public int LängerDerBahn { get; set; }
    }
}
