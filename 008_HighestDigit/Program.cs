// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int number = new Random().Next(10, 99);
int max = 0;
int maxnum1 = number / 10;
int maxnum2 = number % 10;

if (maxnum1 > maxnum2) max = maxnum1;
else
if (maxnum2 > maxnum1) max = maxnum2;

    Console.WriteLine("Дано число: ");
    Console.WriteLine(number);
    
    Console.WriteLine("Наибольшая цифра этого числа: ");
    Console.WriteLine(max);
