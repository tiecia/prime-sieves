using static Algorithms.Algorithms;
using PrimeLibrary;

namespace UnitTests;

public class SieveOfEratosthenesTests
{
    private PrimeFinder _primeFinder;

    public SieveOfEratosthenesTests()
    {
        _primeFinder = new PrimeFinder();
    }

    [Fact]
    public void None()
    {
        var primes = SieveOfEratosthenes(0);
        Assert.Empty(primes);
    }


    [Fact]
    public void First10()
    {
        IEnumerable<int> expected = _primeFinder.GeneratePrimes(0, 30);

        var primes = SieveOfEratosthenes(30);

        Assert.Equal(10, primes.Count());
        Assert.Equal(expected, primes);
    }

    [Fact]
    public void First500()
    {
        IEnumerable<int> expected = _primeFinder.GeneratePrimes(0, 3572);

        var primes = SieveOfEratosthenes(3572);

        Assert.Equal(500, primes.Count());
        Assert.Equal(expected, primes);
    }

    [Fact]
    public void First1000()
    {
        IEnumerable<int> expected = _primeFinder.GeneratePrimes(0, 7920);

        var primes = SieveOfEratosthenes(7920);

        Assert.Equal(1000, primes.Count());
        Assert.Equal(expected, primes);
    }

    [Fact]
    public void Negative()
    {
        var primes = SieveOfEratosthenes(-1);

        Assert.Empty(primes);
    }
}
