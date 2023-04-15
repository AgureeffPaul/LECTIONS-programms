// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//    0       1       2       3
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
//      2     0      1    3
// x = (b2 - b1) / (k1 - k2)
//      1        0
// y = k1 * x + b1

double[] CreateArrayInt(int size)
{
    double[] arr = new double[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите значение :");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.WriteLine($"Введённые значения b1 = {arr[0]}, k1 = {arr[1]}, b2 = {arr[2]}, k2 = {arr[3]}");
}

double SolutionX (double[] arr)
{
    double xx = (arr[2] - arr[0]) / (arr[1] - arr[3]);
    double xxx = Math.Round (xx, 2);
    return xxx;
}

Console.WriteLine("Найдём точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите последовательно значения b1 = , k1 = , b2 = , k2 = ");
double[] array = CreateArrayInt (4);
PrintArray (array);
Console.WriteLine();

double resultX = SolutionX (array);
double x = Math.Round (resultX, 2);
double resultY = resultX * array[1] + array[0];
double y = Math.Round (resultY, 2);
Console.WriteLine($"Координаты точки пересечения заданных прямых [{x};{y}]");