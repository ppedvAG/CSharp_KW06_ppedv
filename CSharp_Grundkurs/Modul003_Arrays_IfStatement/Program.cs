using System;
using System.Linq;

namespace Modul003_Arrays_IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Array Beispiele
            //Definition eines Arrays

            //Deklaration eines Arrays von 3-Feldern 
            int[] intArray = new int[3];
            
            //Arrays verwenden einen Index der bei 0 startet. 
            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;

            //intArray[3] = 4; //OutOfRange Exception 
            

            //Deklaration + Initialisierung
            int[] intArrayB = new int[3] { 1, 2, 3 };

            //Initialisierung legt die größe des Array fest -> Array hat die Length -> von 8 integer-Felder 
            int[] intArrayC = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            int[] intArrayD = { 1, 2, 3, 4, 5, 6 };

            //Kleine Erweiterung 
            //int fieldCount = 5;
            //int[] intArray2 = new int[fieldCount] { 1, 2, 3 };

            //Wenn eine Variable die größe eines Arrays bestimmen soll, wäre die untere Variante besser
            //Array arrayObj = Array.CreateInstance(typeof(int[]), 10);
            //int[]generatedArray = arrayObj.Cast<int>().ToArray();


            int[] zahlen = { 2, 4, 78, -123, -8, 0, 11111 }; //7 Felder -> aber der Höchste Index-Wert wäre 6 

            if (zahlen.Length > 0) //Length ist die Anzahl der Array-Felfer -> 7 (Fehler) 
            {
                Console.WriteLine($"Anzahl des Array: {zahlen.Length} ");
            }

            Console.WriteLine(zahlen.Contains(-123)); //true oder false wird ausgegeben 
            Console.WriteLine(zahlen.Contains(1234));

            //UseCase mit Array und Contain 
            if (zahlen.Contains(501))
            {
                //hat den Wert 501 im Array gefunden 
            }


            //string - Datentyp als Array  (string /char) 
            string beispiel = "Hallo";
            Console.WriteLine(beispiel[2]); //drittes Zeichen von "Hallo" wird ausgegeben 


            for (int counter = 0; counter < zahlen.Length; counter++)
            {
                Console.WriteLine(zahlen[counter]);
            }



            int[,] zweiDimArray = new int[3, 5];

            zweiDimArray[0,0] = 1;

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    zweiDimArray[x, y] = x * y; 
                }
            }

            Console.WriteLine(zweiDimArray[2,3]);
            Console.WriteLine("Ausgabe eines Mehrdimensionales Array");
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Console.WriteLine(zweiDimArray[x,y]);
                }
            }
            #endregion


            #region Boolische Logik in Verbindung mit Schleife

            int a = 10;
            int b = 15;

            //UND: Alle Kriterien müssen stimmig sein (true zurückgegben) 
            if (a== 10 && b== 15)
            {
                Console.WriteLine("a hat den Wert 10 und b hat den Wert 15");
            }
            
            //ODER: Ein Ausdruck muss wahr sein (true zurück geben) 
            if (a == 11 || b == 15)
            {
                Console.WriteLine("Variable  a = 11 ODER Variable b=15");
            }

            int zahl = 369;

            //Ist der Wert der Variable Zahl eine durch 3 Teilbare Zahl. (er Reihenfolge) 
            
            //Modulo % -> Gibt die Restsumme bei der Division zurück. Wenn der Wert 0 ist, dann ist, die Zahl (anhand unseren Beispiels) durch 3 Teilbar
            if (zahl % 3 == 0)
            {
                Console.WriteLine("Zahl gehört zu einer 3er Reihenfolge");
            }
            #endregion


            //Gewinnzahlen als festes Array
            int[] gewinnzahlen = { 3, 16, 45, 79, 99 };


            bool istSchaltjahr = DateTime.IsLeapYear(2000);


            #region 1.Aufgabe: Schaltjahr-Rechner

            //Abfrage der Eingabe
            Console.WriteLine("Gib das Jahr ein:");
            int eingabe = int.Parse(Console.ReadLine());

            //Deklarierung/Initialisierung der bool-Variablen
            istSchaltjahr = false;


            //Alternative 
            bool istSchaltjahr2 = DateTime.IsLeapYear(2000);


            
            //Prüfung einer Teilbarkeit durch 4
            if (eingabe % 4 == 0)
            {
                //Setzten der Variablen auf true
                istSchaltjahr = true;

                //Prüfung einer Teilbarkeit durch 100
                if (eingabe % 100 == 0)
                {
                    //Setzten der Variablen auf false
                    istSchaltjahr = false;

                    //Prüfung einer Teilbarkeit durch 400
                    if (eingabe % 400 == 0)
                        //Setzten der Variablen auf true
                        istSchaltjahr = true;
                }
            }

            //Ausgabe
            Console.WriteLine($"{eingabe} ist Schaltjahr: {istSchaltjahr}");

            //Alternative (detailiertere) Ausgabe mittels Kurz-Bedingung
            string ausgabe = istSchaltjahr ? $"{eingabe} ist ein Schaltjahr." : $"{eingabe} ist kein Schaltjahr.";
            Console.WriteLine(ausgabe + "\n\n\n");

            #endregion
        }
    }
}
