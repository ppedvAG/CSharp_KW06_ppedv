using System;

namespace FunctionSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Überladene Methode
            Addieren(3, 4.5);
            Addieren(3.5f, 3.3f, 3.6f);

            //Params Sample
            ParamsSample(1, 2, 3, 4, 5);
            ParamsSample(12, 3, 4);

            //Optionale PArameter
            Subtrahieren(33, 11, 5, 4);
            Subtrahieren(33, 11, 5);
            Subtrahieren(33, 11);

            Subtrahieren(33, default!); //Bad Code

            int zahl = default!; // 0 wird übergeben 

            


        }

        #region Überladene Funktion

        //Jede Funktion/Methode besteht aus einem Kopf und einem Körper
        ///Der Kopf besteht aus den MODIFIERN (public static), dem RÜCKGABEWERT (int), dem NAMEN (Addiere) sowie den ÜBERGABEPARAMETERN
        static double Addieren(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        //Funktion, welche den gleichen Bezeichner haben, nennt man ÜBERLADENE Funktionen. Diese müssen sich in Anzahl und/oder Art der 
        ///Übergabeparameter unterscheiden, damit der Aufruf eindeutig ist.
        static float Addieren(float zahl1, float zahl2, float zahl3)
            => zahl1 + zahl2;

        
        static double Addieren(double zahl1, double zahl2)
            => zahl1 + zahl2;

        #endregion

        #region params -  Beispiel
        //Das PARAMS-Stichwort erlaubt die Übergabe einer beliebige Anzahl von gleichartigen Daten, welche innerhalb
        //der Methode als Array interpretiert werden
        public static void ParamsSample(params int[] myArray)
        {
            foreach (int item in myArray)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Optionale Parameter 
        ///Wird einem Parameter mittels =-Zeichen ein Defaultwert zugewiesen wird dieser Parameter OPTIONAL und muss bei Aufruf nicht zwangs-
        ///läufig mitgegeben werden. OPTIONALE Parameter müssen am Ende der Parameter stehen.
        public static int Subtrahieren(int a, int b, int c = 0, int d = 0)
        {
            return a - b - c - d;
        }


       public static void OutRefrenceSample1()
       {
            //Wie verhält sich ein Wertetype?

            //Wertetyp: int, decimal, float, bool, struct

            //Wie verhält sich ein Referenztyp?
            //Referenztyp: string, class, interfaces, records


            //ref, out, in 


            string numbersAsText = "12345";
            int number;

            if (int.TryParse(numbersAsText, out number))
            {
                Console.WriteLine(number); //12345
            }
        }

        public static void OutRefrenceSample2()
        {
            int differenz = 0;

            int result = AddiereUndSubrahiereWithOut(15, 9, out differenz);
        }

        //Out -> Muss eine Initialisierung erfahren
        private static int AddiereUndSubrahiereWithOut(int a, int b, out int differenz)
        {
            //wichtiges zu out: Muss eine Wertezuweisung erfahren
            differenz = a - b;

            return a + b;
        }

        //In -> Referenz die nur readonly ist
        private static int AddiereUndSubrahiereWithIn(int a, int b, in int differenz)
        {
            //wichtiges zu in: Es ist nur Readonly
            //geht nicht -> differenz = a - b;
            Console.WriteLine(differenz);
            
            return a + b;
        }


        //Ref - Allgemeine Referenz ohne Regeln und Einschränkungen
        private static int AddiereUndSubrahiereWithRef(int a, int b, ref int differenz)
        {
            //wichtiges zu out: Muss eine Wertezuweisung erfahren
            differenz = a - b;

            return a + b;
        }





        #endregion
    }
}
