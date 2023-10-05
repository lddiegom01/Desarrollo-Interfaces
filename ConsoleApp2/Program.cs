// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, numero!");

string cadena = Console.ReadLine();

int numero = int.Parse(cadena);

if ( numero % 2 == 0 )
{
    Console.WriteLine("par");
} else
{
    Console.WriteLine("impar");
}