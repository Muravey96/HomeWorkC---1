// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите проверяемое число:");
string userInput = Console.ReadLine() ??"";
int number= int.Parse(userInput);

if (number%2 == 0)
{
    Console.Write(number);
    Console.WriteLine(" - число чётное");
}
if (number%2 == 1)
{
    Console.Write(number);
    Console.WriteLine(" - число не чётное");
}
