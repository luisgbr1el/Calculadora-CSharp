using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Calculadora";
            Console.WriteLine("Calculadora");


            double valor1 = 0, valor2 = 0, resultado, numero;
            string operador, valorDigitado;
            bool isNumeroInteiro;

            // Pede o primeiro valor
            Console.WriteLine("Digite o primeiro valor: ");
            valorDigitado = Console.ReadLine();

            // Verifica se é um número inteiro
            isNumeroInteiro = double.TryParse(valorDigitado, out numero);

            // Validação
            if (isNumeroInteiro)
            {
                valor1 = Math.Round(double.Parse(valorDigitado), 4);
            }
            else
            {
                Console.WriteLine("Digite um número válido! ");
            }

            // Pede o segundo valor
            Console.WriteLine("Digite o segundo valor: ");
            valorDigitado = Console.ReadLine();

            // Verifica se é um número inteiro
            isNumeroInteiro = double.TryParse(valorDigitado, out numero);

            // Validação
            if (isNumeroInteiro)
            {
                valor2 = Math.Round(double.Parse(valorDigitado), 4);
            }
            else
            {
                Console.WriteLine("Digite um número válido! ");
            }


            Console.WriteLine("Digite a operação (/ | + | - | * | %(MOD): ");
            operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    resultado = Math.Round(valor1 + valor2, 4);
                    Console.WriteLine($"{ valor1 } {'+'} { valor2} = { resultado }");
                    break;
                case "-":
                    resultado = Math.Round(valor1 - valor2, 4);
                    Console.WriteLine($"{ valor1 } {'-'} { valor2} = { resultado }");
                    break;
                case "*":
                    resultado = Math.Round(valor1 * valor2, 4);
                    Console.WriteLine($"{ valor1 } {'*'} { valor2} = { resultado }");
                    break;
                case "/":
                    resultado = Math.Round(valor1 / valor2, 4);
                    Console.WriteLine($"{ valor1 } {'/'} { valor2} = { resultado }");
                    break;
                case "%":
                    resultado = Math.Round(valor1 % valor2, 4);
                    Console.WriteLine($"{ valor1 } {'%'} { valor2} = { resultado }");
                    break;
                default:
                    Console.WriteLine("Digite uma operação válida!");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
            


        }
    }
}
