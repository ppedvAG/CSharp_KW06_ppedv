using System;
using System.Linq;

namespace Modul003_Arrays_IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
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


            for (int counter = 0; counter <= zahlen.Length; counter++)
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



        }
    }
}
