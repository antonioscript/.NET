using System;

namespace MyApplication
{
  class Car 
  {
    string model;
    string color;
    int maxSpeed;

    static void Main(string[] args)
    {
      Car Ford = new Car(); // Objeto Ford Criado
      Ford.model = "Mustang";
      Ford.color = "blue";
      Ford.maxSpeed = 250;

      Car Fiat = new Car(); // Objeto 'Fiat' Criado
      Fiat.model = "Uno";
      Fiat.color = "red";
      Fiat.maxSpeed = 120;

      // Após criamos dois objetos, podemos acessar os valores
      Console.WriteLine("===Modelo dos Objetos===");
      Console.WriteLine(Ford.model);
      Console.WriteLine(Fiat.model);

      Console.WriteLine("===Cor dos Objetos===");
      Console.WriteLine(Ford.color);
      Console.WriteLine(Ford.maxSpeed);

      Console.WriteLine("===Velocidade dos Objetos===");
      Console.WriteLine(Ford.color);
      Console.WriteLine(Ford.maxSpeed);

      Console.WriteLine("=====Testando======");
      Console.WriteLine("O Modelo do Carro é " + Fiat.model + " e sua cor é " + Fiat.color);
    }
    }
}