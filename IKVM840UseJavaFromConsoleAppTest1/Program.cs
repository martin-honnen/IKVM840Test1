using System;

namespace IKVM840UseJavaFromConsoleAppTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World: {0}", new Test1().getJavaVersion());
        }
    }
}
