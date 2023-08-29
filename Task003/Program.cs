/*
Задача 3: Из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен наименьший элемент.
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

//Метод который позволяет найти первый наименьший элемент:

int[] FindMinEl(int[,] arr)
{
    int min = arr[0,0];
    int n = 0;
    int m = 0;
    int[] index = new int[2];
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] < min) 
            {
                min = arr[i,j];
                n = i;
                m = j;
            } 
        }
    }

    index[0] = n;
    index[1] = m;
    return index;
}

//Метод убирающий строку и столбец с минимальным элементом:

int[,] DeleteRowColMin(int[,] arr, int[] ind)
{
    int n = 0;
    int m = 0;
    int[,] result = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    for (int i=0; i < arr.GetLength(0); i++)
    {
        if (i == ind[0]) continue;
        for (int j=0; j < arr.GetLength(1); j++)
        {
            if (j == ind[1]) continue;
            result[n,m] = arr[i,j];
            m++;
        }
        m = 0;
        n++;
    }
    return result;
}





int[,] mas = GetArray();
Console.WriteLine("Исходный массив:");
PrintArray(mas);
Console.WriteLine();

int[] indexMin = FindMinEl(mas);

Console.WriteLine($"Индекс строки с минимальным элементом: {indexMin[0]}");
Console.WriteLine($"Индекс столбца с минимальным элементом: {indexMin[1]}");
Console.WriteLine();

Console.WriteLine("Массив с удалённым минимальным элементом:");
PrintArray(DeleteRowColMin(mas, indexMin));




/*


// Задача 3: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] matrix = GetArray(5, 5);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"{String.Join(", ", FindMin(matrix))}");
Console.WriteLine();
PrintArray(TrimmArray(matrix, FindMin(matrix)));

int[,] GetArray(int m, int n){
    int[,] matrix = new int[m, n];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = new Random().Next(1, 9);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] FindMin (int[,] matrix){
    int minValue = matrix[0,0];
    int[] minIndex = new int[2];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            if (matrix[i, j] < minValue){
                minValue = matrix[i, j];
                minIndex[0] = i;
                minIndex[1] = j;
            }
        }
    }
    return minIndex;
}

int[,] TrimmArray(int[,] matrix, int[] minIndex){
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int row = 0;
    int columns = 0;
    for(int i = 0; i < matrix.GetLength(0); i++){
        if(i == minIndex[0]) continue;
        for(int j = 0; j < matrix.GetLength(1); j++){
            if(j == minIndex[1]) continue;
            result[row,columns] = matrix[i,j];
            columns++;
        }
        columns = 0;
        row++;
    }
    return result;
}



*/