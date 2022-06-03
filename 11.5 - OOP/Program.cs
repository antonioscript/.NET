//Passando parâmetros para o constructor
using System;

namespace MyApplication
{
  class Car // Criei a classe
  {
    public string model; // Criei o field

    public Car(string nomeModelo) // Constructor Recebendo o parâmetro
    {
      model = nomeModelo;
    }

    static void Main(string[] args)
    {
      Car Ford = new Car("Mustangue"); //Criei um objeto da classe Car (isso chamará o construtor)
      Console.WriteLine(Ford.model);

    }
  }
}  