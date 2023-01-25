using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Calculadora
{
    public class Calculadora : ICalculadora
    {

        public void Menu()
        {
            Console.WriteLine("Calculadora\n");
            Console.WriteLine("1 - Adicionar!");
            Console.WriteLine("2 - Subtrair!");
            Console.WriteLine("3 - Multiplicar!");
            Console.WriteLine("4 - Dividir!");
            Console.WriteLine("5 - Sair!");

            Console.WriteLine("\nSelecione uma opção");
            try
            {
                short opcao = short.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1: Adicionar(); break;
                    case 2: Subtrair(); break;
                    case 3: Multiplicar(); break;
                    case 4: Dividir(); break;
                    case 5: Sair(); break;
                    default: Default(); break;
                }
            }
            catch (Exception)
            {
                Default();
            }
        }
        public void Adicionar()
        {
            Console.Clear();
            Console.WriteLine("Adição\n");

            Console.WriteLine("Informe o primeiro valor");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o segundo valor");
            double segundoValor = double.Parse(Console.ReadLine());

            double resultado = primeiroValor + segundoValor;
            Console.WriteLine($"\nO resultado é: {resultado}");
            Console.ReadKey();
            Console.Clear();

            Menu();
        }
        public void Subtrair()
        {
            Console.Clear();
            Console.WriteLine("Subtração\n");

            Console.WriteLine("Informe o primeiro valor");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o segundo valor");
            double segundoValor = double.Parse(Console.ReadLine());

            double resultado = primeiroValor - segundoValor;
            Console.WriteLine($"\nO resultado é: {resultado}");
            Console.ReadKey();
            Console.Clear();

            Menu();
        }
        public void Multiplicar()
        {
            Console.Clear();
            Console.WriteLine("Multiplicação\n");

            Console.WriteLine("Informe o primeiro valor");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o segundo valor");
            double segundoValor = double.Parse(Console.ReadLine());

            double resultado = primeiroValor * segundoValor;
            Console.WriteLine($"\nO resultado é: {resultado}");
            Console.ReadKey();
            Console.Clear();

            Menu();
        }
        public void Dividir()
        {
            Console.Clear();
            Console.WriteLine("Divisão\n");

            Console.WriteLine("Informe o primeiro valor");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o segundo valor");
            double segundoValor = double.Parse(Console.ReadLine());

            double resultado = primeiroValor / segundoValor;

            Console.WriteLine($"\nO resultado é: {resultado}");
            Console.ReadKey();
            Console.Clear();

            Menu();
        }
        public void Sair()
        {
            Console.WriteLine("\nSaindo...");
            Thread.Sleep(2000);
        }
        public void Default()
        {
            Console.WriteLine("\nOpção Invalida!");
            Console.WriteLine("\nRetornando ao Menu...");
            Thread.Sleep(2000);
            Console.Clear();
            Menu();
        }
    }
}
