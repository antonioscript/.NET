using System;
namespace MeuPrograma
{
    class Program
    {
        static void Main()
        {
            //Perguntando peso e altura
            Console.WriteLine("======Calculadora IMC=======");
            Console.WriteLine("Digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
           
           //Formula IMC
            double imc = (peso / (altura * altura));
            Console.WriteLine("Seu IMC é: " + Math.Round(imc,2));

            //Condições
            if (imc < 18.5)
            {
                Console.WriteLine("Classificação: Magreza");
            }
            else if (imc < 24.9) {
                Console.WriteLine("Classificação: Saudável");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }
            else if (imc < 34.9)
            {
                Console.WriteLine("Classificação: Obesidade de Grau I");
            }
            else if (imc < 39.9) 
            {
                Console.WriteLine("Classificação: Obesidade Grau II");
            }
            else
            {
                Console.WriteLine("Classificação: Obesidade Grau III");
            }
        }
    }
}
