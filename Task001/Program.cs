/*
**Задача 1:** Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

8 4 2 4

5 9 2 3

1 4 7 2
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

//Метод меняющий местами первый и последний столбец

int[,] ChangeCol(int[,] arr)
{
    int k = 0;
    for (int i=0; i < arr.GetLength(0); i++)
    {
        k = arr[i,0];
        arr[i,0] = arr[i,arr.GetLength(1)-1];
        arr[i,arr.GetLength(1)-1] = k;
    }
    return arr;
}

//Метод меняющий местами первую и последнюю строки

int[,] ChangeString(int[,] arr)
{
    int k = 0;
    for (int j=0; j < arr.GetLength(1); j++)
    {
        k = arr[0,j];
        arr[0,j] = arr[arr.GetLength(0)-1,j];
        arr[arr.GetLength(0)-1,j] = k;
    }
    return arr;
}

int[,] mas = GetArray();
PrintArray(mas);
Console.WriteLine();
Console.WriteLine("Меняем местами столбцы первый и последний:");
PrintArray(ChangeCol(mas));
Console.WriteLine();
Console.WriteLine("Меняем местами строки первую и последнюю:");
PrintArray(ChangeString(mas));