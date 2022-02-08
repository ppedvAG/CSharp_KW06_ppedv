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

        static double Addieren(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        static float Addieren(float zahl1, float zahl2, float zahl3)
            => zahl1 + zahl2;

        static double Addieren(double zahl1, double zahl2)
            => zahl1 + zahl2;

        #endregion

        #region params -  Beispiel
        public static void ParamsSample(params int[] myArray)
        {
            foreach (int item in myArray)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Optionale Parameter 
        public static int Subtrahieren(int a, int b, int c = 0, int d = 0)
        {
            return a - b - c - d;
        }
        #endregion
    }
}
