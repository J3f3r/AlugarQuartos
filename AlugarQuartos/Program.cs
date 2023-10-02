using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlugarQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());// n é o numero de quartos q será alugado

            Estudante[] vetor = new Estudante[10];// vetor é iniciado com 10 pq são a qntdd de quartos é sabida

            for(int i = 1; i <= n; i++)// tem que iniciar com 1 pq tem pelo menos um quaarto alugado e <= pq inclui o ultimo quarto
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel # {i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int Quarto = int.Parse(Console.ReadLine());
                vetor[Quarto] = new Estudante (nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i < 10; i++)
            {
                if(vetor[i] != null)
                {
                    Console.WriteLine(i + ": " + vetor[i]);
                }
            }
        }
    }
}
