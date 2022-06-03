//Entrada de Dados
using System;
class Program 
{
    static void Main()
    {
        // Programa que pergunta o nome e mostra na tela
        Console.WriteLine("Digite Seu Nome: ");
        string name = Console.ReadLine(); // Variável que irá armazenar
        //Mostrando o resultado na tela
        Console.WriteLine("Seu nome é: " + name);
        
        Console.WriteLine("------------------------------------");
        
        // OBSERVAÇÃO: -> 'Convert.ToInt32'
        //Progrma que pergunta a idade e mostra na tela
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine() );
        Console.WriteLine("Your age is: " + age);
        
    }
}

