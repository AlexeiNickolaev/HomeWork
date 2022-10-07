// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите любое трехзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int result = number % 10;

Console.WriteLine("Последней цифрой введеного числа является: ");
Console.Write(result);