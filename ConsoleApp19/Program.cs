// See https://aka.ms/new-console-template for more information


Random random = new Random();
int num = random.Next(0, 100);
int intentos = 0;
int respuesta;

Console.WriteLine("Hello, Luis!");

do
{
    Console.Write("Dime la palabro: ");
    respuesta = int.Parse(Console.ReadLine());
    intentos++;

    if (respuesta < num)
    {
        Console.WriteLine("Más alto");
    }
    else if (respuesta > num)
    {
        Console.WriteLine("Más bajo");
    }
    else
    {
        Console.WriteLine("Yow! ganaste ou yeah");
        Console.WriteLine("Número de intentos: " + intentos);
    }
} while (respuesta != num);

Console.WriteLine("bye");