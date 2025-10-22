﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("***** Seřazení dvou čísel *****");
    Console.WriteLine("*******************************");
    Console.WriteLine("******* Tomáš Žižka ***********");
    Console.WriteLine("*******************************");
    Console.WriteLine();

    Console.Write("Zadejte celé číslo - hodnota A: ");
    int a;

    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu A znovu: ");
    }

    Console.Write("Zadejte celé číslo - hodnota B: ");
    int b;

    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu B znovu: ");
    }

    Console.WriteLine();
    int pom;
    if (a > b)
    {
        pom = a;
        a = b;
        b = pom;
        Console.WriteLine("Došlo k prohození proměnných");
    }

    Console.WriteLine($"Seřazená čísla: {a}, {b}");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}




