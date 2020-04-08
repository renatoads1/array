using System;
using System.Globalization;

namespace vetorclase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a quantidade de produtos?");
            int quant = int.Parse(Console.ReadLine());
            //criando vetor de objetos
            Produto[] vet = new Produto[quant];
            for (int i = 0; i < quant; i++) {

                Console.WriteLine("Escreva o nome do produto");
                string nome = Console.ReadLine();
                Console.WriteLine("Escreva o Valor do produto");
                double valor =  double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                vet[i] = new Produto { Nome = nome, Preco = valor };
            }

            double soma = 0.0;
            for (int i = 0; i < quant; i++)
            {
                soma += vet[i].Preco;
            }

            double avg = soma / quant;
            Console.WriteLine("Preço médio =" + avg.ToString());

        }
    }
}
