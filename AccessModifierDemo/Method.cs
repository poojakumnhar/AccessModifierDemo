using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierDemo
{
    class Method
    {
        public void Greet(string a)
        {
            Console.WriteLine(a);
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
    }
    class MethodAssignment
    {
        static void Main(string[],args)
        {
            Method method = new Method();
            method.Greet("Good morning");
            Console.WriteLine();
            Console.WriteLine("Additin of 2 number(12 & 45)is: " + method.Add(12, 45));
        }
    }
}
    


