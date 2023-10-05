// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, numero!");

string cadena = Console.ReadLine();

int numero = 100; // Change this to your desired upper bound
int sum = 0;

for (int i = 1; i <= numero; i++)
{
    sum += i;
}


double average = (double)sum / numero;

Console.WriteLine("total es: "+sum);
Console.WriteLine("la media es: "+average);

