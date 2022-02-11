using System;

namespace ExceptionHandlingSample
{
    internal class Program
    {

        //Exception -> Properties:
        //  -StackTrace ->    at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type)
        //at System.Number.ParseInt32(ReadOnlySpan`1 value, NumberStyles styles, NumberFormatInfo info)
        //at System.Int32.Parse(String s)
        //at ExceptionHandlingSample.Program.Main(String[] args) in C:\Aktueller Kurs\CSharp_KW06_ppedv\CSharp_Grundkurs\ExceptionHandlingSample\Program.cs:line 14



        // - Message: Fehlermeldung für Benutzer 

        // - ToString() -> Message + StackTrace
        
        static void Main(string[] args)
        {
            IntergerConvertService service = new IntergerConvertService();
            try
            {
                service.Convert("abc");
            }
            catch (IntergerConvertServiceException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {

            }
            
        }

        public static void FirstSample()
        {
            try
            {
                Console.Write("Bitte geben Sie eine Zahl ein >");
                string eingabe = Console.ReadLine();

                int number = int.Parse(eingabe); //->beim Umwandeln

                Console.WriteLine(number);
                Console.ReadLine();
            }
            catch (ArgumentException e)
            {
                //logger.LogError(e.ToString());
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) //Jede Exception könne man mit dem Typ Exception abfangen
            {

            }
        }
    }

    public class IntergerConvertService
    {
        public int Convert(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                //Fehler wird eskalieren 
                throw new IntergerConvertServiceException($"Die Eingabe {input} ist keine valide Zahl");
            }
        }
    }

    public class IntergerConvertServiceException : Exception
    {
        public IntergerConvertServiceException(string errorMessage)
            :base(errorMessage)
        {

        }
    }
}
