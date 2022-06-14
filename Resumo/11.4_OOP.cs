using System;

namespace MyApplication
{
  class Car // Criei a classe
  {
    public string model; // Criei o field

    public Car() // Constructor (método especial) da Classe Car
    {
      model = "Mustang";
    }

    static void Main(string[] args)
    {
      Car Ford = new Car(); //Criei um objeto da classe Car (isso chamará o construtor)
      Console.WriteLine(Ford.model);

    }
  }
}  