// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int NumArray = ReadLine("Введите размер массива => ");
int minrnd = ReadLine("Введите нижнию границу массива => ");
int maxrnd = ReadLine("Введите верхнию границу массива => ");
int[] Array = FillArray();
PrintArray(Array);
int sum = 0;
for (int i = 0; i < NumArray; i += 2)
{
    sum = sum + Array[i];
}
System.Console.WriteLine($"=> {sum}");

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