using System;

namespace Modul009_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sq = new Square(12);
            Console.WriteLine($"Area of the square = {sq.GetArea()}");
        }
    }

    abstract class Shape
    {
        public abstract int GetArea();
    }

    class Square : Shape
    {
        private int _side;

        public Square(int n)
        {
            _side = n;
        }

        // GetArea method is required to avoid a compile-time error.
        public override int GetArea() => _side * _side;
    }
}
