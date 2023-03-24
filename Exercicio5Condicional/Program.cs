namespace Exercicio5Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A +B é
            //menor que C.

            int A, B, C, soma;

            Console.WriteLine("Informe 3 valores: ");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());

            soma = A + B;

            if (soma < C)
            {

                Console.WriteLine("A + B = " + soma);
                Console.WriteLine("C = " + C);
                Console.WriteLine("A soma de A + B é menor que C - OPERAÇÃO VERDADEIRA");
            }
            else
            {
                Console.WriteLine("A + B = " + soma);
                Console.WriteLine("C = " + C);
                Console.WriteLine("A soma de A + B é maior que C - OPERAÇÃO INDESEJADA");
            }
        }
    }
}