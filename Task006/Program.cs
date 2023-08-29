/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:

2 4
3 2

3 4
3 3

Результирующая матрица будет:

18 20
15 18
*/

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

//Метод, проверяющий возможно ли выполнить перемножение матриц:

bool CheckMatrix(int[,] array1, int[,] array2)
{
    if (array1.GetLength(0) == array2.GetLength(1)) return true;
    else return false;
}

//Метод, перемножающий матрицы и возвращающий результирующую матрицу:

void Multiplication(int[,] n, int[,] m)
{
    int[,] result = new int[n.GetLength(0), m.GetLength(1)];
    if (CheckMatrix(n, m) == false) Console.WriteLine("Выполнить перемножение двух заданных матриц невозможно!");
    else
    {
        for (int i = 0; i < n.GetLength(0); i++)
        {
            for (int k = 0; k < result.GetLength(1); k++)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    result[i,k] += n[i,j] * m[j,k]; 
                }
            }
        }
        PrintArray(result);
    }
}

//Сама программа:
Console.WriteLine("Исходные данные для первой матрицы:");
int[,] mas1 = GetArray();
Console.WriteLine();
Console.WriteLine("Исходные данные для второй матрицы:");
int[,] mas2 = GetArray();
Console.WriteLine();
Console.WriteLine("Первая матрица:");
PrintArray(mas1);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintArray(mas2);
Console.WriteLine();
Console.WriteLine("Результат перемножения матриц:");
Console.WriteLine();
Multiplication(mas1,mas2);