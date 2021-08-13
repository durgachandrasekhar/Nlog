using System;

namespace NlogSession
{
    class Program
    {
        private static string result;

        static void Main(string[] args)
        {
            Console.WriteLine("Addition on numbers Enter N1,N2 values : " + result);
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            var add = new Addnumber();
            Console.WriteLine("Result is " + " " + add.Sum(a, b));

        }
    }
}