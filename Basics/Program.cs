using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyIntro("Jos", 34, "Tarzanlaan 34");
            Console.WriteLine(BiggestNumber(50, 555, 555));
        }

        static void MyIntro(string name, int age, string address)
        {
            Console.WriteLine($"I am {name} and am {age} years old and I live in {address}");
        }

        static int BiggestNumber(int n1, int n2, int n3)
        {
            int biggestNumber = 0;
            if (biggestNumber < n1)
            {
                biggestNumber = n1;
            }
            if (biggestNumber < n2)
            {
                biggestNumber = n2;
            }
            if (biggestNumber < n3)
            {
                biggestNumber = n3;
            }
            return biggestNumber;
        }
    }
}
