using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace InterfacesInNETCore
{
    internal class Program
    {

        //asynchrone Main-Methode
        static async Task Main(string[] args)
        {
            Person person = new Person();
            
            Stream stream = null;
            try
            {
                //Code -> hier könnte auch einmal ein Fehler passieren
                stream = File.OpenWrite("Person.bin");

                BinaryFormatter binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(stream, person);
            }
            catch (Exception ex) //Wenn hier hin kommst, ist ein Fehler passiert
            {
                //Wird im Fehlerfall ausgeführt 
            }
            finally
            {
                //Wird immer ausgeführt und soll für Aufräumarbeiten genutzt werden.
                stream.Close();
            }

            using (Stream stream2 = File.OpenWrite("Person2.bin"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(stream2, person);
            }//stream aubgebaut / stream.Dispose(); -> stream.Close()


            using (Person p = new Person())
            {

            } //Personen Instanz wird hier abgeaut 

            using Person p1 = new Person(); //Am Ende der Methode wird abgebaut


        } //GC -> person - Instanz wird abgebaut 
    }


    #region IDispose
    public class Person : IDisposable
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "Max Mustermann";
        public int Age { get; set; } = 33;


        
        public void Dispose()
        {
            Console.WriteLine("Objekt wird abgebaut");

            //Angenommen Personen-Klassen verwendet als Member-Variable (Field) eine SqlConnection oder Stream - Klasse, kann diese in Dispose z.b abgebaut werden -> z.b stream.Dispose() 
        }
    }

    #endregion


    #region IConeable

    public class Rock : ICloneable
    {
        int weight;
        bool round;
        bool mossy;

        public Rock(int weight, bool round, bool mossy)
        {
            Weight = weight;
            Round = round;
            Mossy = mossy;
        }

        public int Weight { get => weight; set => weight = value; }
        public bool Round { get => round; set => round = value; }
        public bool Mossy { get => mossy; set => mossy = value; }

        public object Clone()
        {
            return new Rock (Weight, Round, Mossy);
        }

        public override string ToString()
        {
            return $"Gewicht = {Weight} - Round: {Round} - Mossy {Mossy}";
        }
    }
    #endregion


}
