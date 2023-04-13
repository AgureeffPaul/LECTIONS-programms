// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int SumNumbers (int[] arr)
{
     int sumNum = 0;
     int i = 1;
     while (i < arr.Length)
    {
        sumNum = sumNum + arr[i];
        i = i + 2;
    }
    return sumNum;
}


Console.WriteLine("Введите количество чисел в массиве");
int sizeNNN = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayInt (sizeNNN, -99, 99);
Console.WriteLine("Исходный массив");
PrintArray (array);
Console.WriteLine();

int result = SumNumbers (array);
Console.WriteLine($"Сумма чисел на нечётных позициях (индексах) равна : {result}");


