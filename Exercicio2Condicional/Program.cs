namespace Exercicio2Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Escreva um algoritmo que lê três valores para os lados de um triângulo. O algoritmo deve
            //verificar se o triângulo é equilátero(todos os lados iguais), isósceles(dois lados iguais) ou
            //escaleno(todos lados diferentes).

            int lado1, lado2, lado3;

            Console.WriteLine("Entre com a  medida do lado1: ");
            lado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com a  medida do lado2: ");
            lado2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com a  medida do lado3: ");
            lado3 = Convert.ToInt32(Console.ReadLine());


            if ((lado1 == lado2) && (lado2 == lado3))
            {
                Console.WriteLine("É um triângulo equilátero");
            }
            else if ((lado1 == lado2) || (lado2 == lado3) || (lado1 == lado3))
            {
                Console.WriteLine("É um triângulo isóceles");
            }
            else 
            {
                Console.WriteLine("É um triângulo escaleno");
            }

        }
    }
}