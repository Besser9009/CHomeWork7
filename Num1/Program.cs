Console.Clear();
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Write("Введите число строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[i, j];
void NewArray(double[,] array, double minValue, double maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().Next(-100, 100) + new Random().NextDouble(), 1);
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine("");
    }
}
NewArray(array, -100.0, 100.0);