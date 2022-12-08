using System;

namespace IKVM840UseJavaFromConsoleAppTest1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World: .NET {0}, Java {1}", Environment.Version, new Test1().getJavaVersion());
        }
    }
}
