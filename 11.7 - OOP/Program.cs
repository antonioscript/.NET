using System;
namespace Constr
{
    class Car
    {
        public string model;    
        public string color; 
        public int ano;

        public Car(string nomeModel, string nomeColor, int nomeAno)
        {
            model = nomeModel;
            color = nomeColor;
            ano = nomeAno;
        }
        
        static void Main(string[]args)
        {   // 3 Objetos
            Car Ford = new Car("Mustangue", "Vermelho", 1989);
            Car Honda = new Car("Civic", "Prata", 2016);
            Car Nissan = new Car("Versa", "Preto", 2020);

            //Podemos acessar qualquer atributo dos objetos criados
            Console.WriteLine(Honda.ano);
        }
    }
}