// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, What is your name?");
var userName = Console.ReadLine ();
Console.WriteLine($"Hello, {userName},What is your favorite color?");
var color = Console.ReadLine();
Console.WriteLine($"{color} is a great color! What's your favorite animal?");
var animal = Console.ReadLine();
Console.WriteLine("Last question. What is your favorite band?");
var band = Console.ReadLine();
Console.WriteLine($"Name: {userName}");
Console.WriteLine($"Favorite Color: {color}");
Console.WriteLine($"Favorite Animal: {animal}");
Console.WriteLine($"Favorite Band: {band}");