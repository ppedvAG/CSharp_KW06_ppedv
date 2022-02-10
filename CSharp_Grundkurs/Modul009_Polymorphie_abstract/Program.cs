using System;

namespace Modul009_Polymorphie_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //abstrakte Klassen lassen sich nicht instanzieren 
            //BaseClass baseClass = new BaseClass();

        }
    }

    public abstract class BaseClass
    {

        //Wenn eine Methode als abstrakt markiert wird, dann wird die Klasse auch abstract
        public abstract void AbstractMethode(); //abstrakte Methoden haben keinen Body {}
       

        public void MethodeMitBody()
        {
            //Hier Body 
        }

        public abstract int X { get; set; }
        public abstract int Y { get; set; }

        public virtual int Z { get; set; }  

        public virtual string Display()
        {
            return $"Hallo von BaseClass Implementierung";
        }
    }

    public  class DerivedClass : BaseClass
    {
        private int x;
        private int y;

        public override int X 
        { 
            get 
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public override int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public override void AbstractMethode()
        {
            Console.WriteLine("DerivedClass -> abstrakte Methode ist nun überschrieben");
        }
    }

    public class SubDerivedClass : DerivedClass
    {
        private int x = 10;

        public override void AbstractMethode()
        {
            //base.AbstractMethode();
            Console.WriteLine("SubDerivedClass -> abstrakte Methode ist nochmals überschrieben");
        }

        public override int X
        {
            get
            {
                return x + 10;
            }

            set
            {
                x = value + 10;
            }
        }
    }
}
