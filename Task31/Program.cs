﻿// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Lenght; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");     
    }
    Console.Write("]");
}
int[] SumPositiveNegativeElem(int[] arr)
{
    int sumPositive = 0; 
    int samNegative = 0;
    for(int i = 0; i < arr.Lenght; i++)
    {
        if(arr[i] > 0) sumPositive += arr[i];
        else samNegative += arr[i];
    }
    return new int[]{sumPositive,samNegative};
}
int SumPositiveElem(int[]arr)
{
    for (int i = 0; i < arr.length; i++)
    {
                if(arr[i] > 0) sum += arr[i];

    }
    return sum;
}
int SumNegativeElem(int[]arr)
{
    for (int i = 0; i < arr.length; i++)
    {
        if(arr[i] < 0) sum += arr[i];

    }
    return sum;
}
int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
Console.WriteLine();

int[] sumPositiveNegativeElem = SumPositiveNegativeElem (array);
Console.WriteLine(&"Сумма положительных элементов = {sumPositiveNegativeElem[0]}");
Console.WriteLine(&"Сумма отрицательныз элементов = {sumPositiveNegativeElem[1]}");

int sumPositiveElem = SumPositiveElem(array);
int sumNegativeElem = SumNegativeElem(array);
Console.WriteLine(&"Сумма положительных элементов = {sumPositiveElem}");
Console.WriteLine(&"Сумма отрицательныз элементов = {sumNegativeElem}");