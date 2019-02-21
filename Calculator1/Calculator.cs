using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set;}
        //public void Clear()
        //{
        //    setResult = 0;
        //}

        public double Add(double a, double b)
        {
            //setResult = a + b;
            //return setResult;
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            double result = Math.Pow(x, exp);
            if (result.Equals(double.NaN))
            {
                throw  new System.ArgumentOutOfRangeException("This is not a number.");
            }
            else if (result.Equals(double.NegativeInfinity))
            {
                throw new System.ArgumentOutOfRangeException("Result is minus infinity.");
            }
            else if (result.Equals(double.PositiveInfinity))
            {
                throw new System.ArgumentOutOfRangeException("Result is plus infinity");
            }

            Accumulator = result;
            return Accumulator;
        }

        //exercise 1.4 Exercise 4
        public double Divide(double a, double b)
        {
            if (b == 0.0)
            {
                throw new System.DivideByZeroException("Parameter 2");
            }
            Accumulator = a / b;
            return Accumulator;
        }


        public double Add(double b)
        {
            return Add(Accumulator, b);
        }

        public double Subtract(double b)
        {
            return Subtract(Accumulator, b);
        }

        public double Multiply(double b)
        {
            return Multiply(Accumulator, b);
        }

        public double Power(double b)
        {
            return Power(Accumulator, b);
        }

        public double Divide(double b)
        {
            return Divide(Accumulator, b);
        }

    }
}
