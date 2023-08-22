using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("----- Claculando alturas médias -----");

        Console.WriteLine();
        Console.Write("Quer calcular a altura média de quantas pessoas? ");
        int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double[] vect = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(); 
            Console.Write("Entre com a altura: ");
            vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double soma = 0.0;
        for (int i = 0;i < n; i++)
        {
            soma += vect[i];
        }

        double media = soma / n;

        Console.WriteLine();
        Console.WriteLine("Você calculou a altura de " + n + " pessoas.");
        Console.WriteLine("A média das alturas é de: " + media);
    }


}