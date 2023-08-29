/*
Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

7 4 2 1
9 5 3 2
8 4 4 2
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

//Метод сортирующий строку массива:

int[] SortArrString(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < (arr.Length - i-1); j++)
        {
            if (arr[j] < arr[j+1])
            {
                temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
            }
        }
    }
    return arr;
}


//Проверка роботоспособности алгоритма сортировки:
/*
int[] array =new int[6] {6, 4, 7, 2, 9, 1};
Console.WriteLine(string.Join(" ",array));
SortArrString(array);
Console.WriteLine(string.Join(" ",array));
*/



//Метод сортирующий двумерный массив:

int[,] SortArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    int[] res = new int[array.GetLength(1)];
    for (int i= 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res[j] = array[i,j];
        }
        res = SortArrString(res);
        for (int k=0; k < res.Length; k++)
        {
            result[i,k] = res[k];
        }
    }
    return result;
}


//Сама программа:
int[,] mas = GetArray();
Console.WriteLine("Исходный массив:");
PrintArray(mas);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
Console.WriteLine();
PrintArray(SortArray(mas));