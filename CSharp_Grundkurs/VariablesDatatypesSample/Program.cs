using System;

namespace VariablesDatatypesSample
{
    internal class Program
    {

        //Einstieg deines Programms + args - Argumente 
        //Aufruf eines Programmes mit Argumenten >VariablesDatatypesSample.Exe arg1 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region Variablen - Deklaration / Initialisierung
            //Deklaration einer Integer Variable
            int alter;
            //Initialisierung einer Ingeger-Variable
            alter = 32;

            //Zeichenketten
            string stadt = "Berlin";

            Console.WriteLine(alter);
            Console.WriteLine(stadt);

            //Deklaration und Initialisierung einer Integer Variablen mithilfe einer anderen Integer Variablen 
            int doppeltesAlter = alter * 2;
            //shortcut für Console.WriteLine
            Console.WriteLine(doppeltesAlter);
            
            Console.WriteLine(doppeltesAlter + alter); //Integer-Berechnung innerhalt einer Consolen-Ausgabe

            #endregion

            #region char / string 
            char textzeichen = 'A'; //char -> stellen die Zeichen (Zeichentabelle) und können auch die Positionen der Zeichen-Tabelle ausgeben 
            Console.WriteLine(textzeichen);


            //einfache Variante String-Ausgabe in Kombination mit einer einfachen Integer Variablen
            string einfacherString = "Hallo! Ich bin ein String-Zeichenkette und gebe eine Variable aus: " + alter;

            //printf 
            Console.WriteLine("Hallo! Ich bin ein String-Zeichenkette und gebe eine Variable aus: {0} - {1}", alter, doppeltesAlter);

            Console.WriteLine($"Hallo! Ich bin ein String-Zeichenkette und gebe eine Variable aus: {alter} - {doppeltesAlter}");



            string str = $"Hallo ich bin der Kevin und wäre zu gerne nochmal {alter}";
            Console.WriteLine(str);


            //Berechnung innerhalb eines Strings 

            int a = 45;
            int b = 12;
            Console.WriteLine($"{a} + {b}");


            //Was sind EscapeZeichen in einem String
            //https://docs.microsoft.com/de-de/cpp/c-language/escape-sequences?view=msvc-170
            string withEscapes = "Dies ist ein Text mit einem Tabulator \t und gleich kommt es zum Zeilenumbruch \n Dieser Text sollte auf der nächsten Zeile stehen";

            Console.WriteLine(withEscapes);
            //Verbatim-String

        

            string pfad_mit_escapeZeichen = "C:\\Windows\\Temp";



            //Verbatim-String im Einsatz -> Escape-Zeichen werden deaktiviert. 
            string verbatimWithEscapes = @"Dies ist ein Text mit einem Tabulator \t und gleich kommt es zum Zeilenumbruch \n Dieser Text sollte auf der nächsten Zeile stehen";

            string pfad_als_verbatimString = @"C:\Windows\Temp";

            string zeichenketteMitZeilenumbruch = @"Hallo das ist ein String 
                mit einem Zeilenumbruch und dies ist ein    Tabulator";
            #endregion

            #region von String mithilfe der Console
            //Einlesen von Zeichenkette
            Console.Write("Bitte geben Sie den Namen ein > "); //Eingabe - Prombt steht hinter ausgabe in der selben Zeile
            string eingabe = Console.ReadLine();

            //Neue Zeile wird hier verwendet 
            Console.WriteLine($"Hallo mein Name ist {eingabe}");

            //Einlesen von Zahlen
            Console.Write("Bitte geben Sie ihre Lieblingszahl ein: ");
            
            //Zahl liegt als Zeichenkette vor
            string input = Console.ReadLine();

            int meineLieblingsZahl = int.Parse(input);
            //int.TryParse() -> damit können wir überprüfen, ob eine Konventierung geklappt hat 

            int alternativeUmwandlungInZahl = Convert.ToInt32(input);

            //Convert.ToInt32 vs int.Parse -> https://code-maze.com/csharp-intparse-vs-convert-toint32/
            #endregion

            #region Zahlentypen in der Übersicht
            int integer = 123;
            long longInteger = long.MaxValue; //höchster Wert des long-Zahlenraums 
            short shortInteger = short.MaxValue;
            byte byteInteger = byte.MaxValue;
            #endregion

            #region Gleitkomma-Zahlen
            //decimal soll für Geldbeträge verwendet werden 
            decimal derDatenFuerDasGeld = 1_000_000m; //Wert 1.000.000 wird der Variable übergeben 


            double zero = 0.0;
            double z = 2 / zero;
            Console.WriteLine(z);


            //Umwandlung mithilfe von Casten 
            int intZahl = 78;
            double doubleZahl = intZahl;
            Console.WriteLine(doubleZahl);

            doubleZahl = 45.75;
            intZahl = (int)doubleZahl;
            Console.WriteLine(intZahl);

            float floatNumber = 23.7889f;
            Console.WriteLine(floatNumber);

            #endregion 
        }
    }
}
