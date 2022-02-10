using System;

namespace SOLID_002_OpenClosePrincip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    #region BadCode
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public class BadReportGenerator
    {
        public string ReportType { get; set; } = string.Empty;

        public void GenreateReport(Employee em)
        {
            if (ReportType == "CR")
            {
                //Report -> CrystalReports Lib
            }
            else if (ReportType == "PDF")
            {
                //Report PDF
            }
        }
    }
    #endregion


    #region Best Practice - Variante 1

    //Open


    //Abstrakte Klasse vs. Interface in der Abstraktions - Ebene

    //siehe Builder-Design Pattern -> Interface-Implemntierung und eine abstrakte Implementierung 



    public abstract class GeneratorBase
    {
        public abstract void GenreateReport(Employee em);

       

        public virtual void Info()
            => Console.WriteLine("Meine Programm-Version: ");
    }


    //Close
    public class CRGenerator : GeneratorBase
    {
        //Weeitere Optionale Stukturen einbauen 
        //   z.B:   - Templayevorlagen 
        //          - Weitere Optionale Einstellungen u.a OuputVerziechnis

        public override void GenreateReport(Employee em)
        {
            //Generiere ein Crystal Report
        }
    }

    public class PDFGenerator : GeneratorBase
    {
        //Compress Rate
        //Meta-Info Anzeige
        //OutputDirectory
        //Watermark 

        public override void GenreateReport(Employee em)
        {
            //
        }
    }

    #endregion

    #region Variante
    //Open
    public interface IGenerator
    {
        void GenreateReport(Employee em);
    }


    //Close
    public class PDFGenerator1 : IGenerator
    {
        public void GenreateReport(Employee em)
        {
            //any Code
        }
    }

    public class CRGenerator1 : IGenerator
    {
        public void GenreateReport(Employee em)
        {
            //any Code
        }
    }

    #endregion
}
