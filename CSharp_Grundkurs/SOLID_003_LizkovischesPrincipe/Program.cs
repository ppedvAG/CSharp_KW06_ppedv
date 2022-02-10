using System;

namespace SOLID_003_LizkovischesPrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    #region BadCode

    public class BadKirche
    {
        public string GetColour()
        {
            return "rot";
        }
    }

    public class BadErdbeere : BadKirche
    {
        public string GetFarbe()
        {
            return base.GetColour();
        }
    }
    #endregion

    #region Better
    public abstract class Fruits
    {
        public abstract string GetColour();
    }

    public class Erdbeere : Fruits
    {
        public override string GetColour()
        {
            return "rot";
        }
    }

    public class Kirche : Fruits
    {
        public override string GetColour()
        {
            return "rot";
        }
    }

    #endregion
}
