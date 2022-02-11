using Microsoft.Extensions.DependencyInjection;
using SOLID_004_DependencyInversion;
using System;

namespace DependencyInversionAndIOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interface + Klasse -> DependencyInversion (SOLID REGEL 4) -> ICar mockCar = new MockCar();
            ICar mockCar = new MockCar();

            //Wenn man mit Dependenca Inversion arbeiten können wir Loose Kopplung erstellen
            //-> Implemtierung von ICarService.Repaur(ICar car) zu finden

            //Interface + Klasse -> DependencyInversion (SOLID REGEL 4)  -> ICarService service = new CarService();
            ICarService service = new CarService();
            service.Repair(mockCar); //Lose Kopplungen (Überbegriff) -> (Methoden Injection oder Konstruktor Injection) 


            //Programmstart werden alle relevanten Objekt-Instanzen (mit seinen Interfaces) in einen IOC - Container gelegt, damit diese
            //später wiederverwendet werden -> Seperation of Concerne (Wiederverwendbarkeit) 

            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ICarService, CarService>(); //ERstellt eine Instanz -> ICarService service = new CarService();
            
            //Initialisierungen sind fertig -> IOC Container wird nach BuildServiceProvider Instanzen anbieten können
            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            //Irgendwo im Programm
            ICarService myCarServiceInstance = serviceProvider.GetService<ICarService>();
            //CarService Objekt wird zurück gegeben -> mit folgenden Aufbau  -> ICarService service = new CarService();
        }
    }
}
