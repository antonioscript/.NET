//An enumé uma "classe" especial que representa um grupo de constantes 
//(variáveis ​​imutáveis/somente leitura).
using System;

namespace MyApplication
{
  enum Level
  {
    Low,
    Medium,
    High
  }
  class Program
  {
    static void Main(string[] args)
    {
      Level myVar = Level.Medium;
      Console.WriteLine(myVar);
    }
  }
}