using System;
using System.Runtime.InteropServices;

namespace checkOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Operating system is {OSPlatform.Windows}: {RuntimeInformation.IsOSPlatform(OSPlatform.Windows)}");
            Console.WriteLine($"Operating system is {OSPlatform.Linux}:   {RuntimeInformation.IsOSPlatform(OSPlatform.Linux)}");
            Console.WriteLine($"Operating system is {OSPlatform.OSX}:     {RuntimeInformation.IsOSPlatform(OSPlatform.OSX)}");
        }
    }
}
