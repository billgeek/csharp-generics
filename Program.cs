using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myTestClass = new TestClass();
            var randomValue = myTestClass.DoSomething<int, string>(123);
            Console.WriteLine($"The value is {randomValue}");

            var secondClass = new TestTwo();
            var secondValue = secondClass.DoSomething<string, char[]>("33");
            Console.WriteLine($"Second Value: {secondValue}");
            
        }
    }
}
