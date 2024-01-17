using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceți ora curentă sub forma HH:mm:ss:");
        string inputOraCurenta = Console.ReadLine();

        try
        {
            ConversieBinar(inputOraCurenta);
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Eroare: {ex.Message}");
        }
    }

    static void ConversieBinar(string oraCurenta)
    {
        string[] componenteTimp = oraCurenta.Split(':');

        if (componenteTimp.Length != 3)
        {
            throw new FormatException("Formatul orei nu este corect.");
        }

        int ore = int.Parse(componenteTimp[0]);
        int minute = int.Parse(componenteTimp[1]);
        int secunde = int.Parse(componenteTimp[2]);

        Console.WriteLine($"Ceas binar pentru {oraCurenta}:");
        AfiseazaBinar("Ore", Convert.ToString(ore, 2).PadLeft(5, '0'));
        AfiseazaBinar("Minute", Convert.ToString(minute, 2).PadLeft(6, '0'));
        AfiseazaBinar("Secunde", Convert.ToString(secunde, 2).PadLeft(6, '0'));
    }

    static void AfiseazaBinar(string categorie, string valoareBinar)
    {
        Console.WriteLine($"{categorie}: {valoareBinar}");
    }
}
