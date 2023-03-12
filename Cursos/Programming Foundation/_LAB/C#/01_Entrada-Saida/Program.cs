using System;

namespace Entrada_Saida;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira seu nome:");

        string? nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome} :)"); // Interpolação de String

        Console.ReadKey();
    }
}
 