/*
Напишите программу, которая заполнит спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

//Метод, создающий массив и заполняющий спиралью:

int[,] GetArray()
{
    Console.Write("Введите размерность квадратного массива чисел n=");
    int n = int.Parse(Console.ReadLine()!);
    
    int[,] arr = new int[n,n];
    int count = 0; //счётчик чисел заполняющих массив
    //Math.Pow(n,2) - количество чисел, которое потребуется для заполнения всего массива
    int m = n-1;
    int i = 0;
    int j = 0;
    int ii = m;
    int jj = m;
    
    for (int k = 0; k <= Math.Pow(n,2); k++)
    {
        for (int q = j; q <= jj; q++) //идем по верхней строке вправо
        {   
            arr[i,q] = count;
            count++;
        }
        for (int q = i + 1; q <= ii; q++) //идём по крайнему правому столбцу вниз
        {
            arr[q,jj] = count;
            count++;
        }

        for(int q =jj - 1; q >= j; q--)//идём по нижней строке влево
        {
            arr[ii,q] = count;
            count++;
        }
        for (int q = ii - 1; q >= i + 1; q--)//идём по левому крайнему столбцу вверх
        {
            arr[q,j] = count;
            count++;
        }
        i++;
        j++;
        ii--;
        jj--;
        
    }
    return arr;
}



// Печать массива
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:d3} ");
        }
        Console.WriteLine();
    }
}

//Сама программа:

PrintArray(GetArray());