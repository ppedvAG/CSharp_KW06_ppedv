using System;

namespace Calculator.Lib
{
    public interface ICalculator
    {
        int Addition(int z1, int z2);
        int Subtraktion(int z1, int z2);
        int Multiplikation(int z1, int z2); 
        int Division(int z1, int z2);

    }
    public class MyCalculator : ICalculator
    {
        public MyCalculator()
        {
        }
            

        public int Addition(int z1, int z2)
        {
            return z1 + z2;   
        }

        public int Division(int z1, int z2)
        {
            return z1 / z2;
        }

        public int Multiplikation(int z1, int z2)
        {
            return z1 * z2;
        }

        public int Subtraktion(int z1, int z2)
        {
            return z1 - z2;
        }
    }
}
