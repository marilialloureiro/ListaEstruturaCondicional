using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;

namespace Exercicio8Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8. Escreva um programa que receba dois números inteiros e que disponibilize as opções
            //abaixo e imprima o resultado da operação:
            //• A - retornar o soma de dois números;
            //• S - retornar a subtração de dois números;
            //• M - retornar a multiplicação de dois números;
            //• Q - retornar o quociente inteiro de uma divisão;
            //• E - retornar mensagem de erro(opção inválida).

            int num1, num2, resultado;

            Console.WriteLine("Digite o cálculo matemático que deseja realizar, sendo: ");
            Console.WriteLine("A - SOMA");
            Console.WriteLine("B - SUBTRAÇÃO");
            Console.WriteLine("C - MULTIPLICAÇÃO");
            Console.WriteLine("D - DIVISÃO");
            Console.WriteLine("E - OUTRO");
            char opcao = char.Parse(Console.ReadLine());

            Console.Write("Digite  o 1 número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 2 numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (opcao == 'A')
            {
                resultado = num1 + num2;
                Console.WriteLine("O resultado da SOMA de " + num1 + " + " + num2 + " é = " + resultado);
            }
            else if (opcao == 'B')
            {
                resultado = num1 - num2;
                Console.WriteLine("O resultado da SUBTRAÇÃO de " + num1 + " - " + num2 + " é = " + resultado);
            }
            else if (opcao == 'C')
            {
                resultado = num1 * num2;
                Console.WriteLine("O resultado da MULTIPLICAÇÃO de " + num1 + " * " + num2 + " é = " + resultado);
            }
            else if (opcao == 'D')
            {
                resultado = num1 / num2;
                Console.WriteLine("O resultado da DIVISÃO de " + num1 + " / " + num2 + " é = " + resultado);
            }
            else
            {
                Console.WriteLine("OPÇÃO INVÁLIDA");
            }




        }
    }
}