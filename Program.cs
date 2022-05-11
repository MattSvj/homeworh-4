/*
int NaturalSum(int a)
{
    int sum = 0;
    if(a < 1) return 0;
    else
    {
        for(int i = 1; i <= a; i++)
        {
            sum = sum + i;
        }
        
        return sum;

        
    }
}

int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum of elements is " + NaturalSum(num));
*/

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

/*
int CreateRandomArray(int size)
{
    int[] array = new int[size];
    int j = 0;
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0) j++;
    }
    Console.WriteLine(string.Join(" ", array));
    return j;
}

int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Count of четные is " + CreateRandomArray(num));
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int CreateRandomArray(int size)
{
    int[] array = new int[size];
    int j = 1;
    int suma = 0;
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if(j % 2 != 0)
        {
            suma = suma + array[i];
        }
        j++;
    }
    Console.WriteLine(string.Join(" ", array));
    return suma;
}

int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CreateRandomArray(num));
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double SumElements (int size)
{
    double[] array = new double[size];
    double max = 0;
    double min = 100000000;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100) + new Random().NextDouble();
        if (max < array[i])
                {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    Console.WriteLine(string.Join(" ", array));
    return max - min;
}

int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumElements(num));
