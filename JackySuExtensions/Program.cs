using System;
using JackySuExtensions.GenericExtensionsTestCase;
using JackySuExtensions.IEnumerableExtensionsTestCase;

namespace JackySuExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCase = new GenericExtensionsTest();
            testCase.Run();
            var testCase2 = new IEnumerableExtensionsTest();
            testCase2.Run();
            Console.ReadKey();
        }
    }
}
