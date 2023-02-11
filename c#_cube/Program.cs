// Напишите программу показывающую кубы чисел, заканчивающихся на четную цифру

Console.Clear();

int[] numbers = new int[]{6,11,22,33,58,62};
 
for (int i = 0; i < numbers.Length; i++)
{
     int number = numbers[i];
     int cube = (int)Math.Pow(number, 3);
     if (cube % 2 == 0)
          Console.WriteLine($"Куб числа {number} равен {cube} и заканчивается на чётную цифру");
}

