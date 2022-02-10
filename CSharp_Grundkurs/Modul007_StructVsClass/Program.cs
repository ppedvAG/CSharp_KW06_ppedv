using System;

namespace Modul007_StructVsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonS personS = new PersonS(35, "Anna");
            PersonC personC = new PersonC(35, "Pascal");
            PersonC personC2 = null;

            Altern(personC); //Structs sind Wertetypen -> Eine Kopie wird übergeben 
            Altern(personS);

            Console.WriteLine($"Person-Class: {personC.Alter}");
            Console.WriteLine($"Person-Struct: {personS.Alter}");


            AlternWithRef(ref personS);
            Console.WriteLine($"Person-Struct: {personS.Alter}");


            //Diese Zuweisung ist sehr langsam -> Er kopiert jede Property seperat (Deep Copy) 
            personC2 = personC;

            //struct mit ref Zuweisen 
            //Beispiel: 
           


        }

        public static void Altern(PersonS personS) //Kopie wird hier übergeben -> personS
        {
            personS.Alter++;
        }

        public static void Altern(PersonC personC)
        {
            personC.Alter++;
        }

        public static void AlternWithRef(ref PersonS person)
        {
            person.Alter++;
        }
    }


    public struct PersonS
    {
        public int Alter { get; set; }
        public string Name { get; set; }

        public PersonS(int alter, string name)
        {
            Alter = alter;
            Name = name;
        }

        public void SayHello()
        {
            //Sagt Halloo 
        }
    }


    public class PersonC
    {
        public int Alter { get; set; }
        public string Name { get; set; }

        public PersonC(int alter, string name)
        {
            Alter = alter;
            Name = name;
        }

        public void SayHello()
        {
            //Sagt Halloo 
        }
    }
}
