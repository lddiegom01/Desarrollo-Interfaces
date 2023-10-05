// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, luis!");

Console.WriteLine("* | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 ");
Console.WriteLine("______________________________________");

int numero = 1;
int esc;

for ( int i= 1; i < 10; i++)
{
    Console.Write(" "+i+"| ");
    
    for (int j = 1; j < 10; j++)
    {
        esc = j*i;
        Console.Write(esc+"  ");
        numero++;
    }

    Console.WriteLine("");
 
}