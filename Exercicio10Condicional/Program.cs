namespace Exercicio10Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10. Fazer um algoritmo em para ler o código de um determinado produto e mostrar a sua
            //classificação.Utilize a seguinte tabela como referência:
            //      1 - Alimento não precivel
            //      2, 3 ou 4 - Alimento perecível
            //      5 ou 6 - Vestuário
            //      8 a 15 - Higiene Pessoal
            //      Outro - Inválido

            int codigo;

            Console.WriteLine("Informe o código do produto: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            if (codigo == 1)
            {
                Console.WriteLine("Alimento não perecível");
            }
            else if (codigo == 2 || codigo == 3 || codigo == 4)
            {
                Console.WriteLine("Alimento perecível");
            }
            else if (codigo == 5 || codigo == 6)
            {
                Console.WriteLine("Vestuário");
            }
            else if (codigo >=8 && codigo <= 15)
            {
                Console.WriteLine("Higiene pessoal");
            }
            else 
            {
                Console.WriteLine("Código Inválido");
            }
        }
    }
}