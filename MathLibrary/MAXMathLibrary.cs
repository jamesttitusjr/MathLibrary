using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// add subtract multiply divide modulo
namespace MAX
{
    public class MAXMathLibrary

        public const decimal PI = 3.1415927m;
        
        public int Add(int a, int b)
    {
        return a + b;
    }
        public int Subtract(int a, int b)
    {
        return a - b;
    }
        public int Multiply(int a, int b)
    {
        return a * b;
    }
        public int Divide(int a, int b)
    {
        return a / b;
    }
        public int Modulo
    {
        return a - (a / b * b);
    }

 
