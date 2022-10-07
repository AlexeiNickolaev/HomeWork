// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int number1 = new Random().Next(10, 1000);
Console.WriteLine("Задано число ");
Console.WriteLine(number1);

Console.WriteLine("Введите число, желательно кратное заданному");
int number2 = int.Parse(Console.ReadLine() ?? "0");

int result = (number1 % number2);

if (result == 0)
{
    Console.WriteLine("Введенное число кратно заданному!");
}     
else
{
    Console.WriteLine("Введенное число не кратно заданному, остаток от деления равен:");
    Console.WriteLine(result);
}

