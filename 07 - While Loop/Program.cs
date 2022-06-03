using System;

class Hello
{
    static void Main()
    { 
       //While Loop
       int a = 0;
       while (a < 5) 
       {
           Console.WriteLine(a);
           a++; // ou a = a + 1;
       }
       
       Console.WriteLine("--------------------------");
       
       // Do While Loop
       int b = 0;
       do 
       {
           Console.WriteLine(b);
           b++;
       }
       while (b < 5);
       
    }
}