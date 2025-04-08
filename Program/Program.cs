using System.Diagnostics;
using static Algorithms.Algorithms;

Console.WriteLine("Enter a number to generate primes to: ");
var str = Console.ReadLine();


if (!int.TryParse(str, out int max))
{
    Console.WriteLine("Invalid input");
    Environment.Exit(-1);
}


var eratosthenesTime = TimeTask(() => SieveOfEratosthenes(max));
var atkinTime = TimeTask(() => SieveOfAtkin(max));

Console.WriteLine($"Eratosthenes: {eratosthenesTime}");
Console.WriteLine($"Atkin: {atkinTime}");


static TimeSpan TimeTask(Action action)
{
    var stopwatch = new Stopwatch();
    stopwatch.Start();
    action();
    stopwatch.Stop();
    return stopwatch.Elapsed;
}
