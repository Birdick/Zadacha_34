// Задайте массив, заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}

void NumEven(int[] EvenMassive)
{
    int count = 0;
    for (int i = 0; i < EvenMassive.Length; i++)
    {
        if (EvenMassive[i]%2 == 0) count++;
    
    }
    Console.WriteLine($"The even numbers quantiry is {count}");
}

Console.Write("Enter the massive size: ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Enter the minimum massive number: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Enter the maximum massive number: ");
int max = int.Parse(Console.ReadLine()!);
int[] Array = GetArray(size, min, max);
Console.WriteLine($"[{string.Join(", ", Array)}]");
NumEven(Array); 


