// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// Домашняя работа. УСПЕХ!!!

int[] CreateArrayInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int FindNumbers (int[] arr)
{
     int findNum = 0;
     for (int i = 0; i < arr.Length; i ++)
    {
        int ost = arr[i] % 2;
        if (ost == 0)
        {
            findNum = findNum + 1;
        }
    }
    return findNum;
}


Console.WriteLine("Введите количество чисел в массиве");
int sizeNNN = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayInt (sizeNNN, 100, 999);
Console.WriteLine("Исходный массив");
PrintArray (array);
Console.WriteLine();

int result = FindNumbers (array);
Console.WriteLine($"Количество чётных чисел в массиве равно : {result}");


