// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3
// Задача домашняя. Делал сам.

int[] CreateArrayInt(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}е число :");
        arr[i] = Convert.ToInt32(Console.ReadLine());
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

int PlusNumbers (int[] arr)
{
     int plusNum = 0;
     for (int i = 0; i < arr.Length; i ++)
    {
        if (arr[i] > 0)
        {
            plusNum = plusNum + 1;
        }
    }
    return plusNum;
}

Console.WriteLine("Введите количество чисел M, которое хотите ввести :");
int sizeNNN = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayInt (sizeNNN);
Console.WriteLine("Введённые числа :");
PrintArray (array);
Console.WriteLine();

int result = PlusNumbers (array);
Console.WriteLine($"Количество введённых чисел больше нуля равно : {result}");