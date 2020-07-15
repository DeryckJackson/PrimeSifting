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

    [TestMethod] 
    public void RemoveMultiples_RemoveMultiplesOfAnEntry_Match()
    {
      PrimeSifting prime = new PrimeSifting(10);
      prime.RemoveMultiples(2);
      List<int> expected = new List<int> {2, 3, 5, 7, 9};
      CollectionAssert.AreEqual(expected, prime.GetPrimeList());
    }

    [TestMethod]
    public void RemoveAll_RemoveAllMultiplesRemainingOnList_Match()
    {
      PrimeSifting prime = new PrimeSifting(10);
      prime.RemoveAll();
      List<int> expected = new List<int> {2, 3, 5, 7};
      CollectionAssert.AreEqual(expected, prime.GetPrimeList());
    }

    [TestMethod]
    public void RemoveAll_TestAnEvenBiggerList_Match()
    {
      PrimeSifting prime = new PrimeSifting(30);
      prime.RemoveAll();
      List<int> expected = new List<int> {2, 3, 5, 7, 11, 13, 17, 19, 23, 29};
      CollectionAssert.AreEqual(expected, prime.GetPrimeList());
    }
  }
}