using System;

namespace SOLID_004_DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Car() { Brand = "VW", Model = "Polo", ConstructionYear = 2021 };

            //Für Testzwecke:
            ICar mockCar = new MockCar(); 

            ICarService service = new CarService();
            service.Repair(mockCar); //zum Testen
            service.Repair(car); //Produktiv 

        }
    }

    #region Bad Sample


    //Programmier A: 5 Tage -> Tage 1 bis 5 am Arbeiten
    //Beispiel 2-> BadCar -> Entities.dll
    public class BadCar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ConstructionYear { get; set;  }
    }


    //Programmierer B: 3 Tage -> 5 oder 6 -> arbeitet bis mindesten Tag 8
    //Beispiel 2-> BadCarService -> Service.dll
    public class BadCarService
    {

        //Feste Kopplung 
        public void Repair(BadCar car)
        {
            //repariere Auto 
        }
    }

    #endregion


    #region Interfaces bringen eine lose Kopplung
    //Contract First -> Wir schreiben zuerst einmal die Interfaces 



    


    #region Entities.dll
    //Programmierer: 5 Tage (Tag 1 bis 5) 
    public class Car : ICar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ConstructionYear { get; set; }

        public void StarteMotor()
        {
            //Neue Aufgabe
        }
    }
    #endregion


    #region Interface.dll
    //Dauer ein Meeting
    //Programmierer A:
    public interface ICar
    {
        string Brand { get; set; }
        string Model { get; set; }
        int ConstructionYear { get; set; }
    }

    //Programmierer B
    public interface ICarService
    {
        void Repair(ICar car);
    }
    #endregion

    #region CarService.dll
    //Programmierer B -> 3 Tage (Tag 1 bis Tag 3) 
    public class CarService : ICarService
    {
        public void Repair(ICar car)
        {
           //reapiere Auto 
        }
    }

    #endregion

    #region TestLib.dll

    public class MockCar : ICar
    {
        public string Brand { get; set; } = "BMW";
        public string Model { get; set; } = "7er";
        public int ConstructionYear { get; set; } = 2022;
    }
    #endregion

    #endregion
}
