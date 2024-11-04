using System;

namespace OopsDemo
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    Add addObj = new Add();
        //    Console.WriteLine("Addition of two numbers (5, 10): " + addObj.Addition(5, 10));
        //    Console.WriteLine("Addition of three numbers (5, 10, 15): " + addObj.Addition(5, 10, 15));

            
        //    Console.ReadKey();
        //}
    }

    public class Add
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Addition(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
