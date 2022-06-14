// Método passando parâmetro
using System;

class Program
{
    //Método de Dar Boa Noite
    static void saudacao(string name) // Nome do Método
    {
      Console.WriteLine("Boa Noite " + name + "!"); //Função do Método
    }


    // Método de somar dois números
    static void soma(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    
    
    static void Main()
    { 
      saudacao("Bob"); //Chamada da Função
      soma(5, 6); // Chamada da Função
      
      for(int i=0; i<6; i++){
          soma(8,7); // Imprimindo várias vezes o número 15
      }
      
    }
  }