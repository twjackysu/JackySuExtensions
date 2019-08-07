using System;
using System.Linq;
using JackySuExtensions.EnumAdvanced;
using JackySuExtensions.GenericExtensionsTestCase;
using JackySuExtensions.IEnumerableExtensionsTestCase;
using JackySuExtensions.ObjectExtensions;
using JPDataExchange.EnumAdvanced.TestSample;

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

            Function fn = new Function();
            var temp = fn.GetEnumByAttribute<LeaveTypes, Description>(x => x.Any(y => y.ToString().Trim() == "Unpaid Partial /Ttl Disability"));
            Console.ReadKey();
        }
    }
}
