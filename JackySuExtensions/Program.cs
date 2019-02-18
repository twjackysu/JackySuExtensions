using System;
using JackySuExtensions.GenericExtensionsTestCase;
using JackySuExtensions.IEnumerableExtensionsTestCase;
using JackySuExtensions.ObjectExtensions;

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
            var testCase3 = new ObjectExtensionsTest();
            testCase3.Run();
            Console.ReadKey();
        }
    }
}
