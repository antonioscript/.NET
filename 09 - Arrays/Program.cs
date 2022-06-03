using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
              
      //Array em int
      int[] numbers = {10, 20, 30, 40, 50};
      Console.WriteLine(numbers[0]); //Acessando elementos do Array
            
      //Array em string
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      Console.WriteLine(cars[0]); // Acessando elementos do Array
      
      //Modificando itens do array
      cars[0] = "Fusca";
      Console.WriteLine(cars[0]);
      
      //Quantidade de intes do array
      Console.WriteLine(cars.Length); // out = 4
      
      foreach (string i in cars) 
      {
        Console.WriteLine(i); // mostrando em forma de lista
      }         
    }
  }
}