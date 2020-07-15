using Microsoft.VisualStudio.TestTools.UnitTesting;
using Primes.Models;
using System.Collections.Generic;

namespace Primes.Tests
{
  [TestClass]
  public class PrimesTests
  {
    [TestMethod]
    public void PrimeList_InitialListIsCreated_Match()
    {
      PrimeSifting prime = new PrimeSifting(10);
      List<int> expected = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
      CollectionAssert.AreEqual(expected, prime.GetPrimeList());
    }
  }
}