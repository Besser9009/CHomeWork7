Console.Clear();
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Write("Введите число строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[i, j];
void GetArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine("");
    }
}
GetArray(array, -100, 100);
System.Console.WriteLine("");
void ArithmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        Console.Write($"{sum / i},{sum % i}  ");

    }
}
ArithmeticMean(array);