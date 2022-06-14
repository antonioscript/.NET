// Herança
using System;
namespace Heranca
{
  class Veiculo //Classe Pai
  {
      public string marca = "Ford"; 
      public void buzinar() // Método da Função Pai
      {
          Console.WriteLine("Bi, bi, biii!");
      }
  }
  class Car : Veiculo // Classe Filho 
  {
      public string nome = "Mustang"; 
  }
  class Program 
  {
      static void Main(string[]args)
      {
          Car myCar = new Car(); //Criado o objeto
          myCar.buzinar(); // Chamando o método da Classe Pai

          Console.WriteLine("Meu carro é: " + myCar.marca); // Acessando field da classe Pai
      }
  }   
}