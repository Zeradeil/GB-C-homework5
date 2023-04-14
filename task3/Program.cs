// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int NumArray = ReadLine("Введите размер массива => ");
int minrnd = ReadLine("Введите нижнию границу массива => ");
int maxrnd = ReadLine("Введите верхнию границу массива => ");
int[] Array = FillArray();
PrintArray(Array);
DifMaxMin(Array);

void DifMaxMin(int[] Array)
{
    int min = Array[0];
    int max = Array[0];
    for (int i = 1; i < Array.Length; i++)
    {
        if (max < Array[i])
        {
            max = Array[i];
        }
        if (min > Array[i])
        {
            min = Array[i];
        }
    }
    System.Console.WriteLine($"=> {max - min}");
}

int ReadLine(string massage)
{
    System.Console.Write(massage);
    return Convert.ToInt32(System.Console.ReadLine());
}

int[] FillArray()
{
    int[] array = new int[NumArray];
    for (int i = 0; i < NumArray; i++)
    {
        array[i] = new Random().Next(minrnd, maxrnd);
    }
    return array;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < NumArray; i++)
    {
        System.Console.Write($"{Array[i]} ");
    }
}


