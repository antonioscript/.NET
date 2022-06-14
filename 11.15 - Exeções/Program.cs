/*

try 
{
  //  Block of code to try
}
catch (Exception e)
{
  //  Block of code to handle errors
}

*/

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        int[] myNumbers = {1, 2, 3};
        Console.WriteLine(myNumbers[10]); // Vai dar erro pois não existe o termo [10]
      }
      catch (Exception e)
      {
        Console.WriteLine("Alguma coisa errada aconteceu!");
      }    
    }
  }
}