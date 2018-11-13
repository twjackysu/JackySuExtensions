using System;
using JackySuExtensions.GenericExtensionsTestCase;

namespace JackySuExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCase = new GenericExtensionsTest();
            testCase.Run();
            Console.ReadKey();
        }
    }
}
