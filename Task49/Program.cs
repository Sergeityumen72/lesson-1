﻿// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength; i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.Write("|");
    }
}

void SearchEvenIndexRaplaceQuart(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j ])
        }
    }
}
int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);