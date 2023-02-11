// Напишите программу вычисления произведения чисел от 1 до N

Console.Clear();

Console.Write("Введите число N: ");
int num = int.Parse(Console.ReadLine()!);
int result = 1;
for (int i = 1; i <= num; i++)
{
     result = result * i;
}
Console.WriteLine($"Произведение чмсел от 1 до N равно {result}");
