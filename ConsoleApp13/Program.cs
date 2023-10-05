// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Luis!");

Console.Write("Dime los estudiantes: ");
int numestudiantes = int.Parse(Console.ReadLine());

if (numestudiantes <= 0)
{
    Console.WriteLine("Tiene que haber mas de 0 estudiantes");
    return;
}

double[] notas = new double[numestudiantes];
double total= 0;

for (int i = 0; i < numestudiantes; i++)
{
    Console.Write("Dime la nota del estudiante #" + (i + 1) + ": ");
    double nota = double.Parse(Console.ReadLine());

    if (nota < 0 || nota > 100)
    {
        Console.WriteLine("ERROR");
        i--; 
    }
    else
    {
        notas[i] = nota;
        total += nota;
    }
}

double media = total / numestudiantes;

Console.WriteLine("La media de las notas es: " + media);