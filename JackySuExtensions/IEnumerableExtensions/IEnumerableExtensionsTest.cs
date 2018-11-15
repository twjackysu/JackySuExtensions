using JackySuExtensions.IEnumerableExtensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace JackySuExtensions.IEnumerableExtensionsTestCase
{
    public class IEnumerableExtensionsTest
    {
        public class YourObj
        {
            public int P1 { get; set; }
            public YourObj2 P2 { get; set; }
        }
        public class YourObj2
        {
            public int P1 { get; set; }
            public DateTime P2 { get; set; }
        }
        public void Run()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            var data = new List<YourObj>() {
                new YourObj() { P1 = 5, P2 = new YourObj2(){ P1 = 2, P2 = new DateTime(2018,5,3)} },
                new YourObj() { P1 = 3, P2 = new YourObj2(){ P1 = 1, P2 = new DateTime(2018,10,15)} },
                new YourObj() { P1 = 1, P2 = new YourObj2(){ P1 = 0, P2 = new DateTime(2018,10,15)} },
                new YourObj() { P1 = 8, P2 = new YourObj2(){ P1 = 0, P2 = new DateTime(2018,8,10)} },
                new YourObj() { P1 = 3, P2 = new YourObj2(){ P1 = 0, P2 = new DateTime(2018,5,9)} }
            };
            for (int i = 0; i <50000; i++)
            {
                data.Add(new YourObj() { P1 = random.Next(50), P2 = new YourObj2() { P1 = random.Next(50), P2 = new DateTime(2018, random.Next(1, 10), random.Next(1, 27)) } });
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var maxTimeObjs = data.FindMaxPropertyItems(x => x.P2.P2).ToList();
            sw.Stop();
            Console.WriteLine("These objects have the max time");
            foreach (var obj in maxTimeObjs)
            {
                Console.WriteLine(JsonConvert.SerializeObject(obj));
            }
            Console.WriteLine($"Spend time: {sw.ElapsedMilliseconds}");
        }
    }
}
