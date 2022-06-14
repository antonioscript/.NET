// Encapsulamento (Get e Set)

using System;
namespace Encapsulmaneto
{
    class Person
    {
        public string Name  // property
        { get; set; }
    }
    
    class Program 
    {
        static void Main(string[]args)
        {
            Person myObj = new Person();
            myObj.Name = "Maria"; //Observe que foi o Name Maiúsculo
            Console.WriteLine(myObj.Name);
        }
    }
}