using System;

namespace Calculo_IMC2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Olá! \nDigite Seu Nome!");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual sua Idade?");
            float idade = (float) Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Qual seu Peso?");
            float peso = (float) Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Qual a sua Altura?");
            float altura = (float) Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Seu Nome: " + nome);
            Console.WriteLine("Sua Idade: " + idade);
            Console.WriteLine("Seu Peso: " + peso);
            Console.WriteLine("Sua Altura: " + altura);

            float Result = peso / (altura * altura);

            if (Result < 18.5)
            {
                Console.WriteLine("Abaixo do Peso.");
            }
            else if (Result >= 18.5 && Result < 25)
            {
                Console.WriteLine("Peso Normal.");
            }
            else if (Result >= 25 && Result < 30)
            {
                Console.WriteLine("Sobrepeso.");
            }
            else if (Result >= 30)
            {
                Console.WriteLine("Obesidade.");
            }

        }
    }
}
