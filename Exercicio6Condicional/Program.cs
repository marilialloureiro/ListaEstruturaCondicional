using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Xml.Schema;

namespace Exercicio6Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6.Elabore um algoritmo que calcule o que deve ser pago por um produto, considerando o
            //preço normal de etiqueta e a escolha da condição de pagamento. Utilize os códigos da
            //tabela a seguir para ler qual a condição de pagamento escolhida e efetuar o cálculo
            //adequado.Códigos de condição de pagamento:
            //            a) À vista em dinheiro ou cheque, recebe 10 % de desconto;
            //            b) À vista no cartão de crédito, recebe 15 % de desconto;
            //            c) Em duas vezes, preço normal de etiqueta sem juros;
            //            d) Em duas vezes, preço normal de etiqueta mais juros de 10 %.

            double precoNormal, valorTotalA, valorTotalB, valorTotalD;
            char opcao;


            Console.Write("Informe o valor da mercadoria: R$ ");
            precoNormal = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(Environment.NewLine + "Digite a forma de pagamento: ");
            Console.WriteLine("A - À vista em dinheiro ou cheque, recebe 10 % de desconto");
            Console.WriteLine("B - À vista no cartão de crédito, recebe 15 % de desconto");
            Console.WriteLine("C - Em duas vezes, preço normal de etiqueta sem juros");
            Console.WriteLine("D - Em duas vezes, preço normal de etiqueta mais juros de 10%");
            opcao = char.Parse(Console.ReadLine());

            Console.WriteLine("OPÇÃO DE PAGAMENTO ESCOLHIDA");

            if (opcao == 'A')
            {
                valorTotalA = precoNormal - (precoNormal * 0.10);
                Console.WriteLine("Opção A: Desconto de 10%, total à pagar: R$ " + valorTotalA);
            }
            else if (opcao == 'B')
            {
                valorTotalB = precoNormal - (precoNormal * 0.15);
                Console.WriteLine("Opção B: Desconto de 15%, total à pagar: R$ " + valorTotalB);
            }
            else if (opcao == 'D')
            {
                valorTotalD = precoNormal + (precoNormal * 0.10);
                Console.WriteLine("Opção D: Em 2x com juros de 10%, total à pagar: R$ " + valorTotalD + ", 2 parcelas de: R$ " + valorTotalD / 2);
            }
            else
            {
                Console.WriteLine("Opção C: Em 2x sem juros, total à pagar: R$ " + precoNormal);
            }


        }
    }
}