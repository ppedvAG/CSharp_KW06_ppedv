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



            string str = $"Hallo ich bin der Kevin und wäre zu gerne nochma {alter}";
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

            Console.ReadKey();

            string pfad_mit_escapeZeichen = "C:\\Windows\\Temp";



            //Verbatim-String im Einsatz -> Escape-Zeichen werden deaktiviert. 
            string verbatimWithEscapes = @"Dies ist ein Text mit einem Tabulator \t und gleich kommt es zum Zeilenumbruch \n Dieser Text sollte auf der nächsten Zeile stehen";

            string pfad_als_verbatimString = @"C:\Windows\Temp";

            #endregion
        }
    }
}
