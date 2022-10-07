// Найти третью цифру числа или сообщить, что её нет
int number = new Random().Next(1, 1000000);
 
Console.WriteLine("Дано число:");
Console.WriteLine(number);

if (number < 100)
{
Console.WriteLine("Третьей цифры нет!");
}
else
{
int a = number;
int b = int.Parse(a.ToString());
{
    Console.WriteLine("Если считать слева направо, то третья цифра числа это:");
    Console.WriteLine(b.ToString()[2]);
}    
int result = number / 100 % 10;
{
    Console.WriteLine("Если считать справа налево, то третья цифра числа это:");
    Console.WriteLine(result);
}
}

