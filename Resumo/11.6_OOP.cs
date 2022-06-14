//Passando Váriooos parâmetros para o constructor
using System;
namespace MyApplication
{
  class Car // Criei a classe
  {
    public string model; // Criei o field
    public string cor; //Criei o field
    public int ano; // Criei o field

    public Car(string nomeModelo, string nomeCor, int anoModelo) // Constructor Recebendo os parâmetros
    {
      model = nomeModelo;
      cor = nomeCor;
      ano = anoModelo;
    }

    static void Main(string[] args)
    {
      Car Ford = new Car("Mustang", "azul", 2016); //Criei um objeto da classe Car (isso chamará o construtor)
      Console.WriteLine("O carro é um " + Ford.model + Ford.cor + Ford.ano);

    }
  }
}  