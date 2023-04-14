// Задача 39. Перевернуть массив.

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

// Array.Reverse(array);
// [1 2 3 4 5] -> [5 4 3 2 1]

void ReverseArray (int[] arr)
{ 
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length-1-i] = temp;
    }
}

Console.WriteLine("Введите количество чисел в массиве");
int sizeNNN = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayInt (sizeNNN, 1, 9);
Console.WriteLine("Исходный массив");
PrintArray (array);
Console.WriteLine();

Console.WriteLine("Зеркальный массив");
ReverseArray(array);
PrintArray (array);
Console.WriteLine();
Console.WriteLine(".... и обратно");
Array.Reverse(array);
PrintArray (array);