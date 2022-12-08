using System;

namespace IKVM840UseJavaFromConsoleAppTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World: .NET {0}, Java {1}", Environment.Version, new Test1().getJavaVersion());
        }
    }
}
