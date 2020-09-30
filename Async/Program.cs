using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
namespace Async
{
    class Program
    {
            static void Main1()
        {
            // TPL - Parallel Programming
            Stopwatch stopwatch = new Stopwatch();

            long[] numbers = { 7, 12, 5, 17, 13, 9 };

            // Sequential Implementation
            stopwatch.Start();

            Console.WriteLine("Sequential Execution::");
            foreach (var num in numbers)
            {
                Console.WriteLine($"{num}! = {Factorial(num)}");
            }

            Console.WriteLine($"Time Elapsed: {stopwatch.ElapsedMilliseconds} ms");


            // Parallel Implementation
            stopwatch.Restart();
            Console.WriteLine("Parallel Execution::");
            Parallel.ForEach(numbers, num =>
            {
                var f = Factorial(num);
                Console.WriteLine($"{num}! = {f}");
            });

            Console.WriteLine($"Time Elapsed: {stopwatch.ElapsedMilliseconds} ms");

        }

        static long Factorial(long number)
        {
            Task.Delay(100);
            return 0;
        }

        static void Main2()
        {
            // Making breakfast

            // Tea Making Process
            // - Turn on the burner (2s)
            // - Place kettle on burner (3s)
            // - Pour Water (5s)
            // - Let it boil (5min)
            // - Grind Masalas (1min)
            // - Put Sugar and masalas (10s)
            // - Pour Milk (5s)
            // - Let it boil (3min)


            // Fry egg
            // - Turn on the burner (2s)
            // - Put pan and oil it (30s)
            // - Crack eggs and whisk it (3min)
            // - Fry (3min)

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // Sequential Version: Expected completion time = 68 sec
            TurnOnBurner();
            PutOnBurner("Kettle");
            Add("Water");
            Boil("Water");
            GrindTeaMasala();
            PutSugarAndMasalas();
            Add("Milk");
            Boil("Milk");
            TurnOnBurner();
            PutOnBurner("Pan");
            AddOil();
            WhiskEggs();
            Fry();
            Serve();
            Console.WriteLine($"Time Elapsed: {stopwatch.ElapsedMilliseconds} ms");
        }

        static async Task Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Parallel Version: Expected completion time = 56 sec
            await TurnOnBurner();
            await PutOnBurner("Kettle");
            await Add("Water");
            await Boil("Water");
            await GrindTeaMasala();
            await PutSugarAndMasalas();
            await Add("Milk");
            await Boil("Milk");
            await TurnOnBurner();
            await PutOnBurner("Pan");
            await AddOil();
            await WhiskEggs();
            await Fry();
            await Serve();
            Console.WriteLine($"Time Elapsed: {stopwatch.ElapsedMilliseconds} ms");
        }

        private static Task Serve()
        {
            Console.WriteLine($"Serving Breakfast.... :)");
            Task.Delay(5000);
            return Task.CompletedTask;
        }

        private static Task Fry()
        {
            Console.WriteLine($"Frying ");
            Task.Delay(10000);
            return Task.CompletedTask;
        }

        private static Task WhiskEggs()
        {
            Console.WriteLine($"Cracking and Whisking Eggs");
            Task.Delay(10000);
            return Task.CompletedTask;
        }

        private static Task AddOil()
        {
            Console.WriteLine($"Adding oil");
            Task.Delay(2000);
            return Task.CompletedTask;
        }

        private static Task Add(string item)
        {
            Console.WriteLine($"Adding {item}");
            Task.Delay(2000);
            return Task.CompletedTask;
        }

        private static Task PutSugarAndMasalas()
        {
            Console.WriteLine("Adding Sugar and Tea Masala");
            Task.Delay(2000);
            return Task.CompletedTask;
        }

        private static Task GrindTeaMasala()
        {
            Console.WriteLine("Grinding Tea Masalas");
            Task.Delay(5000);
            return Task.CompletedTask;
        }

        private static Task PourWater()
        {
            Console.WriteLine("Adding Water");
            Task.Delay(5000);
            return Task.CompletedTask;
        }

        private static Task Boil(string item)
        {
            Console.WriteLine($"Boiling {item}..");
            Task.Delay(10000);
            return Task.CompletedTask;
        }

        private static Task PutOnBurner(string pot)
        {
            Console.WriteLine($"Placing {pot} on burner..");
            Task.Delay(3000);
            return Task.CompletedTask;
        }

        private static Task TurnOnBurner()
        {
            Console.WriteLine("Turning on the burner..");
            Task.Delay(2000);
            return Task.CompletedTask;
        }
    }
}