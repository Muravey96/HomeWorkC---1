//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число а:");
string userInputA = Console.ReadLine() ??"";
int numberA = int.Parse(userInputA);

Console.WriteLine("Введите число b: ");
string userInputB = Console.ReadLine();
int numberB = int.Parse(userInputB);

Console.WriteLine("Введите число с: ");
string userInputC = Console.ReadLine() ??"";
int numberC = int.Parse(userInputC);

int max = numberA;
if (numberA > max) max = numberA;
else if (numberB > max) max = numberB;
else
{
    max= numberC;
} 

Console.Write("наибольшее из введенных чисел = ");
Console.WriteLine(max);
   
