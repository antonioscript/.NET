using System;

namespace MyApplication
{
  class Car // Classe
  {
    string color; // field
    int maxSpeed; // field

    public void aceleracao_Total () // Método (Função)
    {
        Console.WriteLine("O carro está indo o mais rápido que pode!");
    }

    static void Main(string[] args)
    {
      Car myObj = new Car(); // Criei o objeto
      myObj.aceleracao_Total();
    }
    
    }
}