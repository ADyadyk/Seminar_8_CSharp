/*
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

// Создание массива
int[,] GetArray()
{
    Console.Write("Введите количество строк массива: ");
    int m = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов массива: ");
    int n = int.Parse(Console.ReadLine()!);

    
    Console.Write("Введите минимальное значение элемента: ");
    int minValue = int.Parse(Console.ReadLine()!);

    Console.Write("Введите максимальное значение элемента: ");
    int maxValue = int.Parse(Console.ReadLine()!);

    int[,] res = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            res[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

// Печать массива
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

//Метод, подсчитывающий сумму элементов в каждой строке двумерного массива:

int[] StringSum(int[,] arr)
{
    int[] result = new int[arr.GetLength(0)];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            result[i] += arr[i,j];
        }
        Console.WriteLine($"Сумма элементов в строке с индексом {i} равна: {result[i]}");
    }
    Console.WriteLine();
    return result;
}

//Метод, определяющий строку с наименьшей суммой элементов:

void MinSumString(int[] arr)
{
    int minElement = arr[0];
    int minIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElement)
        {
            minElement = arr[i];
            minIndex = i;
        }
    }
    Console.WriteLine($"Индекс строки с минимальной суммой элементов равен {minIndex}.");
}



//Сама программа:
int[,] mas = GetArray();
Console.WriteLine("Исходный массив:");
PrintArray(mas);
Console.WriteLine();
MinSumString(StringSum(mas));