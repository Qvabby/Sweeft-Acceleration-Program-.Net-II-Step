using System;

namespace SyncApp
{
    class Program
    {
        //დავალება 9
        private static SemaphoreSlim semaphore = new SemaphoreSlim(1, 1); //semaphore.
        private static bool isRunning = true;
        static async Task Main(string[] args)
        {

            Task print = Task.Run(() => PrintOnesAndZerosAsync());

            Task showNeo = Task.Run(() => ShowNeoAsync());

            await Task.WhenAll(print, showNeo);

        }
        //0s and 1s message
        static async Task PrintOnesAndZerosAsync()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            while (isRunning)
            {
                await semaphore.WaitAsync();


                Console.Write("0");
                Console.Write("1");

                semaphore.Release();
            }
        }
        //neos message
        static async Task ShowNeoAsync()
        {
            while (isRunning)
            {

                await Task.Delay(5000);

                await semaphore.WaitAsync();    

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n\n\n\nNeo, you are the chosen one\n\n\n\n");
                Console.ForegroundColor = ConsoleColor.Green;

                await Task.Delay(5000);

                semaphore.Release();              
            }
        }

    }
}
