﻿//Посчитайте сумму цифр в числе

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int sum = 0;
while (num > 0)
{
     sum = sum + num%10;
     num = (num/10);
}
Console.WriteLine($"Сумма числа равна {sum}");

