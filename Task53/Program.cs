// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] CreateMatrixRndInt(int rows, int columns, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        
    for (int i = 0; j < matrix.GetLength(0); j++)
    {
        matrix[i, j] = rnd.Next(min, max + 1);
    }
    return matrix;
    }   
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i],6}");     
    }
    Console.Write("]");
}

int[,] createMatrixRndInt = CreateMatrixRndInt(3, 4, -100, 100);
PrintArray(createMatrixRndInt);