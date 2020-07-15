using System;
using Primes.Models;

namespace Primes
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Please input a number to count primes to:");
      try
      {
        int numInput = int.Parse(Console.ReadLine());
        PrimeSifting prime = new PrimeSifting(numInput);
        prime.RemoveAll();
        Console.WriteLine("Your primes are:");
        foreach(int num in prime.GetPrimeList())
        {
          Console.WriteLine(num.ToString());
        }
      }
      catch
      {
        Console.WriteLine("That wasn't a number, please try again!");
        Main();
      }
    }
  }
}