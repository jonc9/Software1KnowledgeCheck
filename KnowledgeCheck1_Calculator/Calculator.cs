using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public int CalcInput(int Number1, int Number2)
{
    return Number1 + Number2;
}


namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public double Divide(double first, double second)
        {
            return first / second;
        }
    }
}   