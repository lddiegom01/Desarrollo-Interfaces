// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Luis!");

Console.Write("Ingrese una cadena de números binarios: ");
string binario = Console.ReadLine();

int decimalResult = 0;

for (int i = binario.Length - 1, exponente = 0; i >= 0; i--, exponente++)
{
    if (binario[i] == '1')
    {
        decimalResult += (int)Math.Pow(2, exponente);
    }
}

Console.WriteLine("El número decimal equivalente es: " + decimalResult);