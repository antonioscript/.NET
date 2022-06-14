  using System;

namespace MyApplication
{
  class Car // Classe
  {
    //Class Members
    string color = "red"; // Atributo de Cor (field)
    int maxSpeed = 200; // Atributo de Velocidade (field)

    static void Main(string[] args) // Criando Objeto
    {
      Car myObj= new Car(); //Objeto
      Console.WriteLine(myObj.color);
      Console.WriteLine(myObj.maxSpeed);
    }
  }
}