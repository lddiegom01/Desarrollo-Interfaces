// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Luis!");

double pi = 0;
double acumulador = 0;
double divisor = 1;
for (int i = 1; i<=666420; i++)
{
    if (i%2!=0)
    {
        acumulador = acumulador + (1/divisor);
    }
    else
    {
        acumulador = acumulador - (1/divisor);
    }

    divisor = divisor + 2;
}

pi = 4* acumulador;

Console.WriteLine("Pi = "+pi.ToString("F25"));
