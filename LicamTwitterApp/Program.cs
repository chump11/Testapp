using Microsoft.Extensions.Hosting;

namespace HelloWorld
{
    class Program
    {
        static async void Main(string[] args)
        {
            Console.WriteLine("Connecting to Twitter to read a simple tweet!");

            using IHost host = Host.CreateDefaultBuilder(args).Build();
            await host.RunAsync();
        }
    }
}
