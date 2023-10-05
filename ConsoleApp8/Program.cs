// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, luis!");

string metros = Console.ReadLine();

double radio = Convert.ToDouble(metros);

double volume = 4*Math.PI*(radio*radio);
double area = (4*Math.PI*(radio*radio*radio))/3;


Console.WriteLine(area+"m2");
Console.WriteLine(volume+"m3");
