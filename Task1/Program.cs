Console.WriteLine("Введите число а:");
string userInputA = Console.ReadLine() ??"";
int numberA = int.Parse(userInputA);

Console.WriteLine("Введите число b: ");
string userInputB = Console.ReadLine();
int numberB = int.Parse(userInputB); 

int max = numberA;
int min = numberB;

if (numberA > max) 
{
    max = numberA;
    min = numberB;
}
else 
{
    max = numberB;
    min = numberA;
}

Console.Write("max =");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
