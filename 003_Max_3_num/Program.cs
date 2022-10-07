// Найти максимальное из трех чисел
int a = 55;
int b = 8;
int c = 12;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);

