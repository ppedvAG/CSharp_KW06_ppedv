using System;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerischeListen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Beispiel IList / List und etwas Linq
            IList<string> cityList = new List<string>();

            cityList.Add("Hamburg");
            cityList.Add("Berlin");
            cityList.Add("München");
            cityList.Add("Stuttgart");
            cityList.Add("Verl");
            cityList.Add("Berlinchen");

            Console.WriteLine(cityList.Count); //Property Count ist schneller 
            Console.WriteLine(cityList.Count()); // als Count() 

            string[] cityArray = cityList.ToArray();

            //Wenn: List<string> cityList = new List<string>();
            //Dann: cityList.AddRange(cityArray);

            cityList.Remove("München");


            //Zugriffmöglichkeiten 

            //Index
            Console.WriteLine(cityArray[0]);

            //Linq-Functions mit eventuellen Lambda
            Console.WriteLine(cityArray.First());

            //Wenn using System.Linq; als Using verwendet wird, können wir folgende Linq-Funktion(en) verwenden
            string searchString = "erl";
            IList<string> selectedCities = cityList.Where(c => c.Contains(searchString)).ToList();

            //Linq/Lamda -> 
            #endregion



            Dictionary<Guid, Car> dictionaryBad = new Dictionary<Guid, Car>();

            IDictionary<Guid, Car> dictionary = new Dictionary<Guid, Car>();



            Car car1 = new Car() { Brand = "VW", Model = "Polo", ConstructionYear = 1999 };
            Car car2 = new Car() { Brand = "BMW", Model = "7er", ConstructionYear = 2006 };
            Car car3 = new Car() { Brand = "Ford", Model = "Focus", ConstructionYear = 2005 };
            Car car4 = new Car() { Brand = "Audi", Model = "Quatro", ConstructionYear = 1991 };

            dictionary.Add(car1.Id, car1);
            dictionary.Add(car2.Id, car2);
            dictionary.Add(car3.Id, car3);
            dictionary.Add(car4.Id, car4);

           

            // dictionary.Add(car1.Id, car1); -> Exception wurde hier geworfen 
            // Dictionary -> Key muss eindeutig sein 

            if (!dictionary.ContainsKey(car1.Id))
                dictionary.Add(car1.Id, car1);
            else
                Console.WriteLine("Key ist schon bekannt");

            foreach (KeyValuePair<Guid, Car> kvp in dictionary)
            {
                //kvp.Value -> get modfier
                //kvp.Key -> get modifiert
            }

            //Anlegen eines Eintrages mit KeyValuePair

            Car newCar = new Car() { Brand = "Madza", Model = "???", ConstructionYear = 2014 };

            KeyValuePair<Guid, Car> cityEntry = new KeyValuePair<Guid, Car>(newCar.Id, newCar);
            dictionary.Add(cityEntry);


            //Hashtable kann alle Objekte als Key und Value verwenden -> Das führt zu einem komplexen Auslesen und ist Fehleranfällig
            Hashtable hashtable = new Hashtable();
            hashtable.Add("hallo", 123);
            hashtable.Add(123, "Hallo");
            hashtable.Add(DateTime.Now, new StringBuilder());

            Queue<string> wartezimmer = new Queue<string>();
            wartezimmer.Enqueue("PatientA");
            wartezimmer.Enqueue("PatientB");
            wartezimmer.Enqueue("PatientC");

            Console.WriteLine(wartezimmer.Peek()); //Liest das älteste Element nur aus
            string patientMitLängsterWartezeit = wartezimmer.Dequeue(); //PathientA
        }
    }

    public class Car 
    {
        public Guid Id { get; set; } 
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ConstructionYear { get; set; }

        public Car()
        {
            Id = Guid.NewGuid(); //Kommt eigentlich nicht in Konstruktor vor -> Guid.NewGuid-> Repository->Insert Methode wird Guid.NewGuid implementiert. 

        }
    }
}
