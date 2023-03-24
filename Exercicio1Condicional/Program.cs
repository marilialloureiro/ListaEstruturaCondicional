namespace ListaEstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Elabore um algoritmo em que efetue a leitura de um valor que esteja entre a faixa de 1 a
            //9. Após a leitura do valor fornecido pelo usuário, o programa deverá indicar uma de duas
            //mensagens: “O valor está na faixa permitida”, caso o usuário forneça o valor nesta faixa,
            //ou a mensagem “O valor está fora da faixa permitida”, caso o usuário forneça valores
            //menores que 1 ou maiores que 9.

            int num;

            Console.WriteLine("Entre com um valor: ");
            num = Convert.ToInt32(Console.ReadLine());

            if ((num < 1) || (num > 9))
            {
                Console.WriteLine("O valor está fora da faixa permitida");
            }

            else
            {
                Console.WriteLine("O valor está na faixa permitida");
            }
        }
    }
}