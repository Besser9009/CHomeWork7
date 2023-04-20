Console.Clear();
// Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
void Number(int[,] array)
{
    bool n = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            if (num == array[i, j])
            {
                n = true;
                break;
            }
            else n = false;
        }
        if (n == true) 
        {
            Console.WriteLine($"{num} -> такое число в массиве есть");
            break;
        }
        else Console.WriteLine($"{num} -> такого числа в массиве нет");
    }

}
Number(array);