using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do estudante:");
        string nome = Console.ReadLine();

        double soma = 0;

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Digite a nota " + i + ":");
            double nota = Convert.ToDouble(Console.ReadLine());
            soma += nota;
        }

        double media = soma / 3;
        Console.WriteLine("A média do estudante " + nome + " é " + media);
    }
}
