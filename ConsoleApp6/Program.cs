// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a  = 0;
int b = 0;
int c = 1;

int fibonacci = 0;
int num1;
int num2;

Console.WriteLine(0);
Console.WriteLine(0);
Console.WriteLine(1);

for (int i = 1; i<=18; i++)
{
    fibonacci = a + b + c;
    Console.WriteLine(fibonacci);

    num1 = c;
    num2 = b;

    c = fibonacci;
    b = num1;
    a = num2;

}