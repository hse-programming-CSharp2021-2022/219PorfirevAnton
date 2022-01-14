using System;

namespace Task02
{
    static class TestClass
    {
        static public int TestMethod(int a, int b)
        {
            return Math.Max(a, b);
        }

    }
    class TestClass2
    {
        public int TestMethod(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {
        delegate int MyDel(int a, int b); 
        static void Main(string[] args)
        {
            MyDel del1 = new MyDel(TestClass.TestMethod);
            TestClass2 test = new TestClass2();
            MyDel del2 = new MyDel(test.TestMethod);
            MyDel del3 = del1 + del2;
            Console.WriteLine(del1(2, 3));
            Console.WriteLine(del2(2, 3));
            Console.WriteLine(del3(2, 3));
        }
    }
}
