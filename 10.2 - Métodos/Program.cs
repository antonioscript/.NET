//Mais um método de parâmetro
using System;
class Program 
{
    //Criando uma função
    static void soma_numeros(int n1, int n2) {
        int soma = n1 + n2;
        Console.WriteLine("A soma de {0} com {1} é: {2}", n1, n2, soma);
    }
    
    static void Main() {
        //Chamando a função
        soma_numeros(5, 4);
    }
}