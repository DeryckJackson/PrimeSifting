using System;
using System.Collections.Generic;

namespace Primes.Models 
{
  public class PrimeSifting 
  {
    public int UpperLimit { get; set; }
    private List<int> _primeList = new List<int> { };
    public PrimeSifting(int number)
    {
      UpperLimit = number / 2;
      for (int i = 2; i <= number; i++)
      {
        _primeList.Add(i);
      }
    }

    public List<int> GetPrimeList()
    {
      return _primeList;
    }

    public void RemoveMultiples(int number)
    {
      
    }
  }
}