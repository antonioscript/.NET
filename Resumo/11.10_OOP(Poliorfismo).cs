// Polimorfismo é o princípio pelo qual duas ou mais classes 
//derivadas de uma mesma superclasse podem invocar métodos 
//que têm a mesma identificação (assinatura) 
//mas comportamentos distintos
using System;
namespace Poliofirsmo
{
    class Animal // Classe Pai
    {
        public virtual void animalSound() // Método da classe pai
        {
            Console.WriteLine("O animal fez um som");
        }
    }
    class Pig : Animal // Classe Filho
    {
        public override void animalSound()
        {
            Console.WriteLine("O Pig fez: Oinc Oinc");
        }
    }
    class Dog : Animal // Classe Filho
    {
        public override void animalSound()
        {
            Console.WriteLine("O Cachorro fez: Au au");
        }
    }
    class Program 
    {
        static void Main(string[]args)
        {
            Animal myAnimal = new Animal(); // Criei o objeto Animal
            Animal myPig = new Pig(); // Criei o objeto Porco
            Animal myDog = new Dog(); // Criei o objeto Cachorro

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        } 
    }
}