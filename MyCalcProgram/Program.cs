using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcProgram
{
    public class Calc
    {
        public double Sum(double x, double y)
        {
            double sum;
            sum = x + y;
            return sum;
        }
        public double Sub(double x, double y)
        {
            double sub;
            sub = x - y;
            return sub;
        }
        public double Mul(double x, double y)
        {
            double mul;
            mul = x * y;
            return mul;
        }
        public double Div(double x, double y)
        {
            double div = 0;
            try
            {
                div = x / y;
            }
            catch (DivideByZeroException) { }
            return div;
        }
        public double Exp(double x, double y)
        {
            double exp = 1;
            if (y > 0)
                for (int i = 1; i <= y; i++)
                    exp *= x;
            else if (y < 0)
                for (int i = -1; i >= y; i--)
                    exp /= x;
            return exp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
