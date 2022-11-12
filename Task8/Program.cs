// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
string userInput= Console.ReadLine() ??"";
int N = int.Parse(userInput);

int count = 1;

while (count < N);
{
    if (count%2 == 0)
    {
        Console.WriteLine(count);
    }
    count = count ++;
}

Console.Write(N);
Console.Write("->");
Console.WriteLine(count);


