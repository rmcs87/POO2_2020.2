using System;

namespace _19_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Proxy!");

            MathService math = new MathService();
            ProxyMath proxyMath = new ProxyMath(math); // DI

            try
            {
                Console.WriteLine(proxyMath.Add(5, 6));
                Console.WriteLine(proxyMath.Add(5, -6));
            }
            catch (Exception e)
            {
                Console.WriteLine($"LOG: {e.Message}");
            }
        }
    }
}
