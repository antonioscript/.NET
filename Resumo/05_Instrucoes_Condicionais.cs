//Instruções Condicionais
using System;

class Hello
{
    static void Main()
    {
       int time = 8;
       if (time < 12)
       {
           Console.WriteLine("Bom dia!");
       }
       else if (time > 18) // No lugar de 'elif' no Python
       {
           Console.WriteLine("Boa Noite");
       }
       else {
           Console.WriteLine("Boa Tarde");
       }
    }
}