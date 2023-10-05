// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int max = 50000;
int arriba = 1;
int abajo = 1;
double suma = 0;
double num = 0;

while (abajo < max)
{
    num = arriba/abajo;
    suma=suma+num;
    abajo++;
}

Console.WriteLine(suma);