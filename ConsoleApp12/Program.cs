// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Luis!");

Console.Write("Dime un numero hexadecimal");
string hexadecimal = Console.ReadLine();

long decimalResult = 0;

for (int i = hexadecimal.Length - 1, exponente = 0; i >= 0; i--, exponente++)
{
    char hexChar = hexadecimal[i];
    int valorDecimal = 0;

    if (char.IsDigit(hexChar))
    {
        valorDecimal = hexChar - '0';
    }
    else
    {
        switch (char.ToLower(hexChar))
        {
            case 'a':
                valorDecimal = 10;
                break;
            case 'b':
                valorDecimal = 11;
                break;
            case 'c':
                valorDecimal = 12;
                break;
            case 'd':
                valorDecimal = 13;
                break;
            case 'e':
                valorDecimal = 14;
                break;
            case 'f':
                valorDecimal = 15;
                break;
            default:
                throw new ArgumentException("MEH ERROR");
        }
    }

    decimalResult += valorDecimal * (long)Math.Pow(16, exponente);
}

Console.WriteLine("El decimal es: " + decimalResult);
 