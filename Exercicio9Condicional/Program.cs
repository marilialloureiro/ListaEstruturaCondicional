using System.Net;
using System.Runtime.ConstrainedExecution;

namespace Exercicio9Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9. Faça um algoritmo para ler a quantidade de horas / aula de dois professores e o valor por
            //hora recebido por cada um. Mostrar na tela qual dos professores tem salário total maior.

            float valorHora;

            Console.Write("Informe o valor da hora/aula de um professor: ");
            valorHora = Convert.ToSingle(Console.ReadLine());

            Console.Write("Informe quantas horas trabalhou o professor Pedro: ");
            float horasPedro = Convert.ToSingle(Console.ReadLine());

            Console.Write("Informe quantas horas trabalhou o professor João: ");
            float horasJoao = Convert.ToSingle(Console.ReadLine());

            float salarioP = horasPedro * valorHora;            
            Console.WriteLine("O salario do prof. Pedro nesse mês foi de R$" + salarioP);
            
            float salarioJ = horasJoao * valorHora;
            Console.WriteLine("O salario do prof. João nesse mês foi de R$" + salarioJ);
            

            if (salarioJ > salarioP)
            {
                Console.WriteLine("Professor João possui um salário maior");
            }
            else 
            {
                Console.WriteLine("Professor Pedro possui um salário maior");
            }
            
        }
    }
}