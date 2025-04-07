/*
  CPSC 450
  Final Project
  Tyler C
*/

namespace Algorithms;

public class Algorithms {

  /// <summary>
  /// Generates a list of prime numbers up to a specified limit using the Sieve of Eratosthenes algorithm.
  /// </summary>
  /// <param name="n">The upper limit (exclusive) up to which to generate prime numbers.</param>
  /// <returns>An IEnumerable of prime numbers up to the specified limit.</returns>
  public static IEnumerable<int> SieveOfEratosthenes(int n) {
    if (n <= 0) {
      return Enumerable.Empty<int>();
    }

    bool[] sieve = new bool[n];

    for (int i = 2; i<Math.Sqrt(n); i++) {
      if (!sieve[i]) {
        int iSquared = i*i;
        for (int j = 0; iSquared + j*i < n; j++) {
          int s = iSquared + j*i;
          sieve[s] = true;
        }
      }
    }

    List<int> primes = new List<int>();
    for (int i = 2; i<sieve.Count(); i++) {
      if (!sieve[i]) {
        primes.Add(i);
      }
    }

    return primes;
  }

  /// <summary>
  /// Generates a list of prime numbers up to a specified limit using the Sieve of Atkin algorithm.
  /// </summary>
  /// <param name="n">The upper limit (inclusive) up to which to generate prime numbers.</param>
  /// <returns>An IEnumerable of prime numbers up to the specified limit.</returns>
  public static IEnumerable<int> SieveOfAtkin(int n) {
    if(n < 2) {
      return [];
    } else if (n == 2) {
      return [2];
    } else if (n == 3) {
      return [2, 3];
    }

    bool[] sieve = new bool[n + 1];

    for (int x = 1; x*x < n; x++) {
      for (int y = 1; y*y < n; y++) {
        int p = (4*x*x) + (y*y);
        if (p <= n && (p % 12 == 1 || p % 12 == 5)) {
          sieve[p] ^= true;
        }

        p = (3*x*x) + (y*y);
        if (p <= n && p % 12 == 7) {
          sieve[p] ^= true;
        }

        p = (3*x*x) - (y*y);
        if (x > y && p <= n && p % 12 == 11) {
          sieve[p] ^= true;
        }
      }
    }

    for (int i = 5; i*i < n; i++) {
      if (sieve[i]) {
        for (int j = i*i; j < n; j += i * i) {
          sieve[j] = false;
        }
      }
    }

    List<int> results = [2, 3];
    for (int i = 2; i<sieve.Length; i++) {
      if (sieve[i]) {
        results.Add(i);
      }
    }

    return results;
  }
}
