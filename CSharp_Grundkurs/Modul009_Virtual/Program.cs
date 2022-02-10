using System;
using System.Collections.Generic;

namespace Modul009_Virtual
{
    internal class Program
    {
        private static IList<Shape> geometryFormsList = new List<Shape>();

        static void Main(string[] args)
        {
            #region Instanziierungen Polymorphie

            Cylinder cylinder1 = new Cylinder(5, 6);
            cylinder1.StehtAufDemBoden();
            cylinder1.Area();

            Shape shape1 = (Shape)cylinder1;
            shape1.Area(); //Cylinder Berechnung wird auch hier ausgegeben


            Shape cylinder2 = new Cylinder(6, 7);
            cylinder2.Area(); //Berechnung von Clyinder aus 

            #endregion


            #region Polymorphie Beispiel

            Circle circle = new Circle(5);
            //geometryFormsList.Add(circle);
            circle.MyVariable = 12345;
            
            Shape circle2 = new Circle(5); //Spin Around ist hier nicht verfügbar -> Shape (Was kennt Shape alles) 
           
            InsertItem(circle);
            InsertItem(circle2);


            DisplayAll();
            #endregion
        }

        private static void InsertItem (Shape shape)
        {
            geometryFormsList.Add(shape);
        }

        private static void DisplayAll()
        {
            foreach (Shape shape in geometryFormsList)
            {
                switch (shape)
                {
                    case Cylinder cylinder:
                        Console.WriteLine($"Zylinder hat eine Fläche von: {cylinder.Area()}");
                        break;
                    case Sphere sphere:
                        Console.WriteLine($"Kugel hat eine Fläche von: {sphere.Area()}");
                        break;
                    case Circle circle:
                        Console.WriteLine($"Kreis hat eine Fläche von: {circle.Area()}");
                        circle.SpinArround();
                        break;
                }
            }
        }
    }

    #region Sample1: Virtual Properties Sample
    class MyBaseClass
    {
        // virtual auto-implemented property. Overrides can only
        // provide specialized behavior if they implement get and set accessors.
        public virtual string Name { get; set; }

        // ordinary virtual property with backing field
        private int _num;
        public virtual int Number
        {
            get { return _num; }
            set { _num = value; }
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        private string _name;

        // Override auto-implemented property with ordinary property
        // to provide specialized accessor behavior.
        public override string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    _name = "Unknown";
                }
            }
        }
    }

    #endregion


    #region Sample2: Virtual Methoden
    public class Shape
    {
        public const double PI = Math.PI;
        protected double _x, _y;

        public Shape()
        {
        }

        public Shape(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public virtual double Area()
        {
            return _x * _y;
        }
    }

    public class Circle : Shape
    {
        public Circle(double r) 
            : base(r, 0)
        {
        }

        public override double Area()
        {
            return PI * _x * _x;
        }

        public void SpinArround()
        {
            Console.WriteLine("Kreis dreht sich");
        }

        public int MyVariable { get; set; }
    }

    public class Sphere : Shape
    {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return 4 * PI * _x * _x;
        }

        public void Rolling()
        {
            Console.WriteLine("Kugel rollt");
        }
    }

    public class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double Area()
        {
            return 2 * PI * _x * _x + 2 * PI * _x * _y;
        }

        public void StehtAufDemBoden()
        {
            Console.WriteLine("Zylinder steht");
        }
    }
    #endregion
}
