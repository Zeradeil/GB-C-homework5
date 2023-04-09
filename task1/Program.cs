// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int NumMassive = ReadLine("Введите размер массива => ");
int[] massive = FillArray();
PrintArray(massive);
CountNumbers(massive);

int ReadLine(string massage)
{
    System.Console.Write(massage);
    return Convert.ToInt32(System.Console.ReadLine());
}

int[] FillArray()
{
    int[] array = new int[NumMassive];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] FillArray)
{
    for (int i = 0; i < massive.Length; i++)
    {
        System.Console.Write($"{massive[i]} ");
    }
}

void CountNumbers(int[] massive)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] % 2 == 0)
        {
            count++;
        }
    }
    if (count == 0)
    {
        System.Console.WriteLine("В массиве нет четных чисел");
    }
    else
    {
        System.Console.WriteLine($"-> {count}");
    }
}
