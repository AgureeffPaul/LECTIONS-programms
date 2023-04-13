// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayInt(int size, double min, double max)
{
    Random rnd = new Random();
    double[] arr = new double[size];
  
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble ();
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

// int Minimum (int[] arr)
// {
//      int min = 0;
//      int i = 1;
//      while (i < arr.Length)
//     {
//         sumNum = sumNum + arr[i];
//         i = i + 2;
//     }
//     return sumNum;
// }


Console.WriteLine("Введите количество чисел в массиве");
int sizeNNN = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayInt (sizeNNN, -99, 99);
Console.WriteLine("Исходный массив");
PrintArray (array);
Console.WriteLine();

// int result = SumNumbers (array);
// Console.WriteLine($"Сумма чисел на нечётных позициях (индексах) равна : {result}");


