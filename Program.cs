using System;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {

            double num1, num2, calc;
            Console.WriteLine("Bem vindo a calculadora!");
            Console.WriteLine("Escolha a opcao: ");
            Console.WriteLine("A - Soma\nB - Subtração\nC - Multiplicação\nD - Divisão");

            string escolha = Console.ReadLine().ToUpper();

            string[] opcao = new string[4];
            {
                opcao[0] = "A";
                opcao[1] = "B";
                opcao[2] = "C";
                opcao[3] = "D";
            }

            Console.Write("Insira o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            
            num2 = double.Parse(Console.ReadLine());


            if (escolha == opcao[0])
            {
                Console.WriteLine("Resultado: {0}", Somar(num1, num2));
            }
            if (escolha == opcao[1])
            {
                Console.WriteLine("Resultado: {0}",Subtrair(num1, num2));
            }
            if (escolha == opcao[2])
            {
                Console.WriteLine("Resultado: {0}", Multiplicar(num1, num2));
            }
            if (escolha == opcao[3])
            {
                Console.WriteLine("Resultado: {0}", Dividir(num1, num2));
            }

            Console.ReadKey();
        }

        public static double Somar(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Dividir(double num1, double num2)
        {
            return num1 / num2;
        }

        
    }


}
