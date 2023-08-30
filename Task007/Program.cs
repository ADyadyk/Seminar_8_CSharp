/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


int[,,] GetArray()
{
    Console.WriteLine("Начинается формирование трехмерного массива заполненного двузначными не повторяющимися числами.");
    Console.WriteLine("Максимальное число элементов в массиве равно максимальному количеству двузначных чисел - 90 шт.");
    Console.WriteLine();
    Console.Write("Введите количество элементов по X (количество строк) массива: ");
    int m = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество элементов по Y  (количество столбцов) массива: ");
    int n = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество элементов по Z  (количество слоев) массива: ");
    int l = int.Parse(Console.ReadLine()!);
    

    int[,,] res = new int[m,n,l];
    return res;
}

//Метод, выводящий массив в консоль:

void PrintArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)//1
    {
        Console.WriteLine($"Индекс слоя: {k}");
        for(int i = 0; i < arr.GetLength(0); i++)//2
        {
            for(int j = 0; j < arr.GetLength(1); j++)//3
            {
                Console.WriteLine($"{arr[i,j,k]} ({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


//Метод, наполняющий трехмерный массив двузначными неповторяющимися числами:

int[,,] FillArray(int[,,] arr)
{
    int[,,] result = new int[arr.GetLength(0), arr.GetLength(1), arr.GetLength(2)];

    //Задаем массив заполненный случаными неповторяющимися двузначными числами:
    int[] numbers = GenRandomMas(arr.GetLength(0)*arr.GetLength(1)*arr.GetLength(2));
    int s = 0; //счётчик для перехода к следующему двузначному числу

    for (int k = 0; k < arr.GetLength(2); k++)//1
    {
        for(int i = 0; i < arr.GetLength(0); i++)//2
        {
            for(int j = 0; j < arr.GetLength(1); j++)//3
            {
                result[i,j,k] = numbers[s]; //присвоение очередного числа из массива случаных чисел
                s++; //переключение счётчика на следующее число
            }
        }  
    }
    return result;
}


//Метод, формирующий одномерный массив заполненный случайными двузначными числами:

int[] GenRandomMas(int Nq)
{
    int Nmin = 10;
    int Nmax = 99;
    int[] qN = new int[Nq];
    int k = 0;
    while (k < Nq)
    {
        int p = new Random().Next(Nmin, Nmax+1);
        bool b = true;

        for (int i = 0; i < k; i++)
        {
            if (p == qN[i])
            {
                b = false;
                break;
            }
        }
        if (b)
        {
            qN[k] = p;
            k++;
        }
    }
    return qN;
}


//Сама программа:

int[,,] mas = GetArray();

if (mas.GetLength(0)*mas.GetLength(1)*mas.GetLength(2) >90)
{
    Console.WriteLine("Максимальное количество элементов в массиве превышает количество двузначных чисел. Программа прерывает свою работу.");
    return;
}

Console.WriteLine("Массив заполненный значениями:");
PrintArray(FillArray(mas));