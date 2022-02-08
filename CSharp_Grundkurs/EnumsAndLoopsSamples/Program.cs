using System;

namespace EnumsAndLoopsSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Schleifen

            int a = 0;
            int b = 10;

            while (a < b)
            {
                Console.WriteLine("A ist kleiner als B");

                a++;

                if (a == 5)
                    break; //Man geht aus der Schleife raus, es gibt keinen weiteren Schleifendurchlauf mehr. 
            }

            Console.WriteLine("Schleifenende");

            a = -45;


            do 
            { //hier beginnt der Schleifendurchlauf 
                Console.WriteLine(a);
                a++;

                if (a == -10)
                {
                    continue; //Sprint zum nächsten Schleifendurchlauf 
                    Console.WriteLine("Kann mich jemand lesen?");
                }
            } while (a < 0);


            int[] zahlen = { 2, 3, 4, 51 };

            //Zählschleife -> 0 bis 99 
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                //for wird verwenden, wenn man eine Index gestütze Liste / Array durchlaufen möchte
            }//Variable i ist nur innerhalb der Schleife verfügbar 
            
            for(int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]); //Achtung vor IndexOutOfRangeException Exception 
            }

            foreach (int currentNumber in zahlen) //verwendet intern eine Zeiger auf den nächsten Datensatz
            {
                Console.WriteLine(currentNumber);

                //foreach ist sicherer als eine for-schleife 
            }


            #endregion


            #region Enums vs Arrays
            string[] wochentage = { "Montag", "Dienstag", "Mittowch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };

            string[] anreden = { "Mr", "Mrs", "Dr", "Prof" };

            //Dienstag wollen wir mithilfe eines Arrays ausgeben 
            Console.WriteLine(wochentage[1]);

            WochentageTyp wochentag = WochentageTyp.Dienstag;

            if (wochentag == WochentageTyp.Dienstag || wochentag == WochentageTyp.Donnerstag)
            {
                Console.WriteLine("Wochentag ist ein Dienstag oder Donnerstag");
            }
            #endregion

            #region Enums


            //Beispiel 1 Zuweiseung und Ausgabe eines Enums
            WochentageTyp heute = WochentageTyp.Dienstag;
            Console.WriteLine($"Heute ist also {heute}.");

            //Via Index -> Enums (fast) komplett ausgeben -> i = 1
            //For-Schleife über die möglichen Zustande des Enumerators
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine($"{i}: {(WochentageTyp)i}");
            }


            Console.WriteLine("Gebe einen Wert zwischen 0 und 6 ein");
            heute = (WochentageTyp)int.Parse(Console.ReadLine()); //2 = Mittwoch 
            Console.WriteLine($"Dein Lieblingstag ist also {heute}.");


            string[] meineWochentage = Enum.GetNames(typeof(WochentageTyp));

            heute = (WochentageTyp)Enum.Parse(typeof(WochentageTyp), "Freitag");
            Console.WriteLine($"Dein neuer Lieblingstag ist also {heute}.");
            #endregion


            #region Enums with switch Vs Enums with If-Statement
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
            #region anti beispiel mit for
            if (heute == WochentageTyp.Montag || heute == WochentageTyp.Dienstag || heute == WochentageTyp.Mittwoch)
                Console.WriteLine("Wochenstart");
            else if (heute == WochentageTyp.Donnerstag || heute == WochentageTyp.Freitag)
                Console.WriteLine("fast schon Wochennde");
            else
                Console.WriteLine("Wochenende");
            #endregion

            #region switch Statement 
            



            switch (heute)
            {
                case WochentageTyp.Montag:
                    Console.WriteLine("Wochenstart");
                    break;
                case WochentageTyp.Dienstag:
                case WochentageTyp.Mittwoch:
                case WochentageTyp.Donnerstag:
                    Console.WriteLine("Normaler Wochentag");
                    break;
                case WochentageTyp.Freitag:
                case WochentageTyp.Samstag:
                case WochentageTyp.Sonntag:
                    Console.WriteLine("Wochenende");
                    break;
                default:
                    Console.WriteLine("Fehlerhafte Eingabe oder es gibt einen 8ten Tag :-) ");
                    break;
            }


            int zahl = -45;

            switch(zahl)
            {
                case 5:
                    Console.WriteLine("zahl == 5");
                    break;
                case int myCastedNumberVariable when myCastedNumberVariable < 0:
                    Console.WriteLine("zahl ist kleiner als 0");
                    break;
            }


            int zahlB = 10;

            switch (zahlB)
            {
                case 0 or 1:
                    Console.WriteLine(zahlB);
                    break;
                case > 0 and < 10:
                    Console.WriteLine(zahlB);
                    break;
                case < 5 or > 10:
                    Console.WriteLine(zahlB);
                    break;
            }

            WochentageTyp currentTag = WochentageTyp.Mittwoch;

            switch ((int)currentTag)
            {
                case 0 or 1:
                    Console.WriteLine(zahlB);
                    break;
                case > 0 and < 10:
                    Console.WriteLine(zahlB);
                    break;
                case < 5 or > 10:
                    Console.WriteLine(zahlB);
                    break;
            }
            #endregion





            #endregion

            #region Bitfelder Enums
            Fruechte fruechteAuswahl = Fruechte.Banane | Fruechte.Birne | Fruechte.Orange; //37

            Fruechte[] myFruits = (Fruechte[])Enum.GetValues(typeof(Fruechte));

            foreach(Fruechte currentFrucht in myFruits)
            {
                if (fruechteAuswahl.HasFlag(currentFrucht) && currentFrucht != Fruechte.Keines)
                {
                    //Wenn Frucht im myFruits vorhanden ist, wird diese ausgegeben 
                    Console.WriteLine(currentFrucht);
                }
            }


            #endregion
        }
    }
    public enum WochentageTyp { Montag, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag }

    [Flags]
    public enum Fruechte { Keines = 0x0, Orange = 1, Kirsche = 2, Banane = 4, Apfel = 8, Pflaume =16, Birne =32 }

}
