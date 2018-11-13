using System;
using JackySuExtensions.GenericExtensions;

namespace JackySuExtensions.GenericExtensionsTestCase
{
    public class YourObj
    {
        public string P1 { get; set; }
        public int P2 { get; set; }
        public YourObj2 P3 { get; set; }
    }
    public class YourObj2
    {
        public int P1 { get; set; }
        public int P2 { get; set; }
    }
    public class GenericExtensionsTest
    {
        public void Run()
        {
            var test1_1 = new YourObj { P1 = "5", P2 = 6, P3 = new YourObj2 { P1 = 666, P2 = 777 } };
            var test1_2 = new YourObj { P1 = "5", P2 = 6, P3 = new YourObj2 { P1 = 666, P2 = 777 } };
            var test2_1 = new YourObj { P1 = "5", P3 = new YourObj2 { P1 = 666, P2 = 777 } };
            var test2_2 = new YourObj { P1 = "5", P3 = new YourObj2 { P1 = 666, P2 = 777 } };
            var test3_1 = new YourObj { P1 = "5", P2 = 6, P3 = new YourObj2 { P1 = 666, P2 = 666 } };
            var test3_2 = new YourObj { P1 = "5", P2 = 5, P3 = new YourObj2 { P1 = 666, P2 = 777 } };
            var test4_1 = new YourObj { P1 = "5", P2 = 6, P3 = new YourObj2 { P1 = 666, P2 = 777 } };
            var test4_2 = new YourObj { P1 = "5", P2 = 5, P3 = new YourObj2 { P1 = 666 } };

            Console.WriteLine(test1_1.EqualsExt(test1_2));
            Console.WriteLine(test2_1.EqualsExt(test2_2));
            Console.WriteLine(test3_1.EqualsExt(test3_2));
            Console.WriteLine(test4_1.EqualsExt(test4_2));
        }
    }
}
