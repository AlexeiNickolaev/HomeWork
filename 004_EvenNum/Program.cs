// Выяснить является ли число чётным
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number % 2 == 0)
{
    Console.WriteLine("Число является четным!");
}
else
{
    Console.WriteLine("Число не является четным!");
}
