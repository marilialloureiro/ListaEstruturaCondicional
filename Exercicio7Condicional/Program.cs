using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace Exercicio7Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.Fazer um algoritmo em para ler o ano de nascimento de uma pessoa, calcular e mostrar
            //sua idade e, também, verificar e mostrar se ela já tem idade para votar(16 anos ou mais)
            //e para conseguir a Carteira de Habilitação(18 anos ou mais).

            int anoNascimento, anoAtual, idade;
            anoAtual = 2023;
                        
            Console.WriteLine("Informe o ano do seu nascimento: ");
            anoNascimento = Convert.ToInt32(Console.ReadLine());

            idade = anoAtual - anoNascimento;
            Console.WriteLine("Atualmente você está com: " + idade + " anos");

            if (idade <= 15)
            {
                Console.WriteLine("Você não pode votar nem tirar habilitação");
            }

            else if (idade > 16 && idade >=18)
            {
                Console.WriteLine("Você pode votar e tirar carteira de habilitação!");
            }
            else 
            {
                Console.WriteLine("Você pode votar!");
            } 




        }
    }
}