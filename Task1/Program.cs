Console.WriteLine("Введите число а:");
string userInputA = Console.ReadLine() ??"";
int numberA = int.Parse(userInputA);

Console.WriteLine("Введите число b: ");
string userInputB = Console.ReadLine();
int numberB = int.Parse(userInputB); 

int max = numberA;

if (numberA > max) max = numberA;
else max = numberB;

Console.Write("max =");
Console.WriteLine(max);
