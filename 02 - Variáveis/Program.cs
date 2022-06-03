//Variáveis
using System;
class Hello 
{
    static void Main()
    {
        // String
        string name = "Jhon";
        Console.WriteLine(name);
        
        // Inteiro
        int number = 14;
        Console.WriteLine(number);
        
        //Ou
        int n2;
        n2 = 15;
        Console.WriteLine(n2);
        
        //Double
        double n3 = 5.99D; // Perceba o "D" no final
        Console.WriteLine(n3);
        
        //Cálculo Básico
        int number1 = 10;
        int number2 = 20;
        Console.WriteLine(number1 + number2);
        
        //Declaração de Variáveis do mesmo tipo na Mesma Linha
        int x = 10, y = 15, z = 35;
        Console.WriteLine(x + y +z);
        
        
        //Tipos Inteiros -> Long and Short
        long myNum = 15000000000L;
        Console.WriteLine(myNum);
        
        // TRASNFORMAÇÃO DE VARIÁVEIS (IMPORTANTE)
        double myDouble = 9.78; 
        int myInt = (int) myDouble;
        Console.WriteLine(myDouble); // Saída = 9.78
        Console.WriteLine(myInt); // Saída = 9
    }
}