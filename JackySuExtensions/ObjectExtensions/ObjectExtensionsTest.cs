using System;
using System.Collections.Generic;
using System.Text;

namespace JackySuExtensions.ObjectExtensions
{
    class ObjectExtensionsTest
    {
        public void Run()
        {
            var test1 = new A()
            {
                a1 = new B[] {
                    new B(){
                        b1 = new C[]
                        {
                            new C(){ c1 = ".a1[0].b1[0].c1" },
                            new C(){ c1 = ".a1[0].b1[1].c1" },
                            new C(){ c1 = ".a1[0].b1[2].c1" },
                        },
                        b2 = new C(){ c1 = ".a1[0].b2.c1" },
                        b3 = ".a1[0].b3"
                    },
                    new B(){
                        b1 = new C[]
                        {
                            new C(){ c1 = ".a1[1].b1[0].c1" },
                            new C(){ c1 = ".a1[1].b1[1].c1" },
                        },
                        b2 = new C(){ c1 = ".a1[1].b2.c1" },
                        b3 = ".a1[1].b3"
                    }
                },
                a2 = new B()
                {
                    b1 = new C[]
                        {
                            new C(){ c1 = ".a2.b1[0].c1" },
                            new C(){ c1 = ".a2.b1[1].c1" },
                        },
                    b2 = new C() { c1 = ".a2.b2.c1" },
                    b3 = ".a2.b3",
                    b4 = false
                },
                a3 = "a3"
            };
            //should be equal
            Console.WriteLine(test1.a1[0].b1[1].c1);
            Console.WriteLine(test1.GetValue("a1[0].b1[1].c1"));

            //".a1[0].b1[1].c1" to "WTF
            test1.SetValue("a1[0].b1[1].c1", "WTF");
            Console.WriteLine(test1.a1[0].b1[1].c1);

            Console.WriteLine("a2.b4 Before: " + test1.a2.b4);
            test1.SetValue("a2.b4", true);
            Console.WriteLine("a2.b4 After: " + test1.a2.b4);

            //should be equal
            Console.WriteLine(test1.a2.b1[1].c1);
            Console.WriteLine(test1.GetValue("a2.b1[1].c1"));

            //should be equal
            Console.WriteLine(test1.a2.b3);
            Console.WriteLine(test1.GetValue("a2.b3"));

            var test2 = new D()
            {
                d1 = new E[][] {
                        new E[] {
                            new E() { e1 = 1 }
                        },
                        new E[] {
                            new E() { e1 = 2 },
                            new E() { e1 = 3 }
                        }
                    }
            };
            Console.WriteLine("d1[1][0].e1 Before: " + test2.d1[1][0].e1);
            test2.SetValue("d1[1][0].e1", 9);
            Console.WriteLine("d1[1][0].e1 After: " + test2.d1[1][0].e1);
        }
    }
    class A
    {
        public B[] a1 { get; set; }
        public B a2 { get; set; }
        public string a3 { get; set; }
    }
    class B
    {
        public C[] b1 { get; set; }
        public C b2 { get; set; }
        public string b3 { get; set; }
        public bool b4 { get; set; }
    }
    class C
    {
        public string c1 { get; set; }
    }
    class D
    {
        public E[][] d1 { get; set; }
    }
    class E
    {
        public int e1 { get; set; }

    }
}
