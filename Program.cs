using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a calculadora de operações básicas");
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine($"Seja bem vindo(a) {nome}, para começar escolha umas das seguintes operações!");
            Console.WriteLine(" ");
            Console.WriteLine(" 1 - Soma");
            Console.WriteLine(" 2 - Subtração");
            Console.WriteLine(" 3 - Multiplicação");
            Console.WriteLine(" 4 - Divisão");
            Console.WriteLine(" 5 - Sair");

            Console.WriteLine("-----------------");

            short resultado = short.Parse(Console.ReadLine());
            
            switch (resultado)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }


        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite um número: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo número: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            int resultado = valor1 + valor2;
            Console.WriteLine($"O valor da soma é: {resultado} !");
            Console.WriteLine("Para fazer outra operação, aperte enter! ");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear ();
            Console.WriteLine("Digite um número: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            int resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é: {resultado} !");
            Console.WriteLine("Para fazer outra operação, aperte enter! ");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite um número:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo número:");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            int resultado = valor1 * valor2;
            Console.WriteLine("O resultado da multiplicação é: " + resultado + " !");
            Console.WriteLine("Para fazer outra operação, aperte enter! ");
            Console.ReadKey();
            Menu();
        }
     static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite um número:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            int resultado = valor1 / valor2;
            Console.WriteLine("O resultado da divisão é: " + resultado + " !");
            Console.WriteLine("Para fazer outra operação, aperte enter! ");
            Console.ReadKey();
            Menu();

        }
    }
}