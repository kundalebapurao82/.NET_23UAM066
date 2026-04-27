using System;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class Program
    {
        // Entry point (must be async in modern C#)
        static async Task Main(string[] args)
        {
            Console.WriteLine("Application Started...");

            // Call async method
            await DownloadDataAsync();

            Console.WriteLine("Application Finished...");
            Console.ReadLine();
        }

        // Asynchronous method
        static async Task DownloadDataAsync()
        {
            Console.WriteLine("Downloading data... Please wait");

            // Simulate long-running task (3 seconds delay)
            await Task.Delay(3000);

            Console.WriteLine("Data downloaded successfully!");
        }
    }
}