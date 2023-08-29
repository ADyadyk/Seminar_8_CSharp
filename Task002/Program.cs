/*
**Задача 2:** Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

В итоге получается вот такой массив:

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7
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

//Метод проверяющий возможность поменять строки со столбцами местами

bool CheckArray(int[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1)) return true;
    else return false;
}

//Метод меняющий местами

int[,] TransArray(int[,] arr)
{
    if (CheckArray(arr) == false)
    {
        Console.WriteLine("Поменять строки и столбцы местами невозможно.");
        Console.WriteLine("Массив остается без изменения:");
        return arr;
    } 
    else
    {
        int [,] arrT = new int[arr.GetLength(1),arr.GetLength(0)];
        for (int i=0; i < arr.GetLength(0); i++)
        {
            for (int j=0; j < arr.GetLength(1); j++)
            {
                arrT[j,i]= arr[i,j];
            }
        }
        return arrT;
    }
}


int[,] mas = GetArray();
Console.WriteLine();
PrintArray(mas);
Console.WriteLine();
Console.WriteLine("Меняем строки на столбцы, если это возможно:");
Console.WriteLine();
PrintArray(TransArray(mas));