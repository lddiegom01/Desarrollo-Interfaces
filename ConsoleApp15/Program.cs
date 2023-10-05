// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Luis!");

Console.Write("Introduce el número de estudiantes: ");
int numestu = int.Parse(Console.ReadLine());

if (numestu <= 0)
{
    Console.WriteLine("El número de estudiantes debe ser mayor que cero.");
    return;
}

double[] notas = new double[numestu];
double sumnotas = 0;
double minimo = double.MaxValue;
double maximo = double.MinValue;

for (int i = 0; i < numestu; i++)
{
    Console.Write("Introduzca la nota del estudiante " + (i + 1) + ": ");
    double nota = double.Parse(Console.ReadLine());

    if (nota < 0 || nota > 100)
    {
        Console.WriteLine("La nota debe estar entre 0 y 100. Inténtelo de nuevo.");
        i--; 
    }
    else
    {
        notas[i] = nota;
        sumnotas += nota;
        if (nota < minimo)
        {
            minimo = nota;
        }
        if (nota > maximo)
        {
            maximo = nota;
        }
    }
}

double media = sumnotas / numestu;

double sumadesv = 0;
for (int i = 0; i < numestu; i++)
{
    sumadesv += Math.Pow(notas[i] - media, 2);
}
double desvtipica = Math.Sqrt(sumadesv / numestu);

Console.WriteLine("La media es " + media);
Console.WriteLine("El mínimo es " + minimo);
Console.WriteLine("El máximo es " + maximo);
Console.WriteLine("La desviación tipica es " + desvtipica);
