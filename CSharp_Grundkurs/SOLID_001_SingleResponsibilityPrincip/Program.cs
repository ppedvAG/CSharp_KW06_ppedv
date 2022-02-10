using System;

namespace SOLID_001_SingleResponsibilityPrincip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    #region Anti-Beispiel

    public class EmployeeBad
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

       //DataAccess -> Employee Datensatz soll in eine Tabelle gespeichert
        public void InsertEmployee(EmployeeBad employee)
        {
            // any Code
        }

        //Ausgabe -> Service oder Präsentation LAyer
        public void GenerateReport()
        {
            // any Code
        }
    }
    #endregion

    #region Bessere Variante
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    //EmployeeRepository manipuliert eine Employee-Tabelle 
    public class EmployeeRepository
    {
        //Connection hinzfügen
        public void InsertEmployee(Employee employee)
        {
            //..Speicher in Tabelle
        }
    }


    public class EmployeeReport
    {

        
        public void GenerateReport()
        {
            // any Code
        }
    }



    #endregion
}
