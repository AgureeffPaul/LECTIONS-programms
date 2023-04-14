// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементом массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// Сделал сам. Работает. Сдать вовремя не успел.

double[] CreateArrayInt(int size, double min, double max)
{
    Random rnd = new Random();
    double[] arr = new double[size];
  
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round (rnd.NextDouble () * (max - min) + min, 2);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double Minimum (double[] arr)
{
     double min = arr[0];
     int i = 0;
     while (i < arr.Length-1)
    {
        if (arr[i] < min) 
        {
            min = arr[i]; 
        }
    i ++;
    }
    return min;
}

double Maximum (double[] arr)
{
     double max = arr[0];
     int i = 0;
     while (i < arr.Length-1)
    {
        if (arr[i] > max) 
        {
            max = arr[i]; 
        }
    i ++;
    }
    return max;
}

double Difference (double resMin, double resMax)
{
    double diffMaxMin = resMax - resMin;
    return diffMaxMin;
}


Console.WriteLine("Введите количество чисел в массиве");
int sizeNNN = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayInt (sizeNNN, 0, 99);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine();

double resultMin = Minimum (array);
Console.WriteLine($"Минимальный элемент : {resultMin}");
double resultMax = Maximum (array);
Console.WriteLine($"Максимальный элемент : {resultMax}");
double finishAnswer = Difference (resultMin, resultMax);
Console.WriteLine($"Разница Макс - Мин : {finishAnswer}");
