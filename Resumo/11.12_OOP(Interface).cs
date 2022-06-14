// An interfaceé uma " classe abstrata ", que só pode conter 
//métodos e propriedades abstratas (com corpos vazios).
//Por padrão, os membros de uma interface são abstracte public.
//Nota: As interfaces podem conter propriedades e métodos, mas não campos.

using System;

namespace MyApplication
{
  // Interface
  interface IAnimal 
  {
    void animalSound(); // interface method (does not have a body)
  }

  // Pig "implements" the IAnimal interface
  class Pig : IAnimal 
  {
    public void animalSound() 
    {
      // The body of animalSound() is provided here
      Console.WriteLine("The pig says: wee wee");
    }
  }

  class Program 
  {
    static void Main(string[] args) 
    {
      Pig myPig = new Pig();  // Create a Pig object
      myPig.animalSound();
    }
  }
}

// Notas Sobre Interfaces:

/* Assim como as classes abstratas , as interfaces não podem 
ser usadas para criar objetos (no exemplo acima, não é 
possível criar um objeto "IAnimal" na classe Program)

Métodos de interface não possuem corpo - o corpo é fornecido pela classe "implement"

Na implementação de uma interface, você deve substituir todos os seus métodos

Interfaces podem conter propriedades e métodos, mas não campos/variáveis

Os membros da interface são por padrão abstracte public

Uma interface não pode conter um construtor (já que não pode ser usada para criar objetos




*/