/*
  CPSC 450
  Final Project
  Tyler C
*/

using static Algorithms.Algorithms;
using PrimeLibrary;

namespace UnitTests;

public class SieveOfAtkinTests
{
    private PrimeFinder _primeFinder;

    public SieveOfAtkinTests() {
      _primeFinder = new PrimeFinder();
    }

    [Fact]
    public void None()
    {
      var primes = SieveOfAtkin(0);
      Assert.Empty(primes);
    }

    [Fact]
    public void First10()
    {
      IEnumerable<int> expected = _primeFinder.GeneratePrimes(0, 29);

      var primes = SieveOfAtkin(29);

      Assert.Equal(10, primes.Count());
      Assert.Equal(expected, primes);
    }

    [Fact]
    public void First500()
    {
      IEnumerable<int> expected = _primeFinder.GeneratePrimes(0, 3571);

      var primes = SieveOfAtkin(3571);

      Assert.Equal(500, primes.Count());
      Assert.Equal(expected, primes);
    }

    [Fact]
    public void First1000()
    {
      IEnumerable<int> expected = _primeFinder.GeneratePrimes(0, 7919);

      var primes = SieveOfAtkin(7919);

      Assert.Equal(1000, primes.Count());
      Assert.Equal(expected, primes);
    }

    [Fact]
    public void Negative()
    {
      var primes = SieveOfAtkin(-1);

      Assert.Empty(primes);
    }
}
