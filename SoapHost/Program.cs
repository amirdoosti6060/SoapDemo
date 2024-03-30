using System;
using System.ServiceModel;

namespace SoapHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(SoapServer.MathService)))
            {
                host.Open();
                Console.WriteLine("Service is running...");
                Console.WriteLine("Press Ctrl+C to stop service.");
                Console.ReadLine();
            }
        }
    }
}
