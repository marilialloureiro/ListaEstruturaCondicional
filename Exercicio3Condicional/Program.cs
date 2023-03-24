namespace Exercicio3Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Faça um algoritmo em que efetue a leitura do nome e do sexo de uma pessoa,
            //apresentando como saída uma das seguintes mensagens: “Ilmo Sr.”, para o sexo informado
            //como masculino, ou a mensagem “Ilma Sra.”, para o sexo informado como feminino.
            //Apresente na sequência da mensagem impressa o nome da pessoa.

            string nome;
            char sexo;

            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sexo (M - Masculino / F - Feminino): ");
            sexo = char.Parse(Console.ReadLine());

            if (sexo == 'M')
            {
                Console.WriteLine("Ilmo Sr." + nome);
            }
            else 
            {
                Console.WriteLine("Ilma Sra." + nome);
            }

        }
    }
}