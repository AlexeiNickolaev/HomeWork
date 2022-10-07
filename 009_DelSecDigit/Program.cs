// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int number2 = (number / 100 * 10 + number % 10);

Console.WriteLine("Если удалить вторую цифру из введеного вами числа, то получится: ");
Console.WriteLine(number2);
