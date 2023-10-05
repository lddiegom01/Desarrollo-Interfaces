// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, Luis!");

        Console.Write("Ingrese una cadena: ");

        string chein = Console.ReadLine();

        string cadenaAlReves = darLaVuelta(chein);

        Console.WriteLine("Cadena al revés: " + cadenaAlReves);
    }

    static string darLaVuelta(string input)
    {
        char[] caracteres = input.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }
}
