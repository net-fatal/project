// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


int[] arr = new int[12];
int k = 0, sum = 0;
Random rnd = new Random();
       
Console.WriteLine("Исходный массив");
for (int i = 0; i < 12; i++)
{
    arr[i] = rnd.Next(10, 50);
    Console.Write("{0} ", arr[i]);
}

       
foreach(int element in arr)
{
Console.Write("{0} ", element);
if (element % 2 == 0)
{
    k++;
    sum += element;
}
}
Console.WriteLine();
Console.WriteLine($"Количество четных элементов {k}, сумма четных элементовn {sum}");