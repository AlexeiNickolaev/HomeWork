// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0" );

int result = (number / 10 % 10);

Console.Write("Вторая цифра введенного вами числа: ");
Console.Write(result);
