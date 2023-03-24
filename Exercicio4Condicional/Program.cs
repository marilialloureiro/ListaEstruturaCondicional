namespace Exercicio4Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4. Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um algoritmo
            //em que calcule peso ideal, utilizando as seguintes fórmulas:
            //• Para homens: (72.7 * h) –58
            //• Para mulheres: (62.1 * h) - 44.7
            //• Onde h equivale à altura da pessoa.

         
            double altura, pesoM, pesoF;
            char sexo;
            
            Console.WriteLine("Informe sua altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu sexo (M - Masculino / F - Feminino): ");
            sexo = char.Parse(Console.ReadLine());

            pesoM = (72.7 * altura) - 58;
            pesoF = (62.1 * altura) - 44.7;

            if (sexo == 'M') 
            {               
                Console.WriteLine("Seu peso ideal é: " + pesoM);             
            }

            else
            {                
                Console.WriteLine("Seu peso ideal é: " + pesoF);
            }
        }
    }
}