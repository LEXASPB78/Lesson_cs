﻿/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю
строку массива.
*/

int[] CreateArrey(int length, int min, int max)
{
    int[] array = new int[length];
    for(int i = 0; i<length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

//-----------------------------------------------------------

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for(int row = 0; row < rowCount; ++row)
    {
        for(int column = 0; column < columnCount; ++column)
        {
            array[row, column] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for(int row = 0; row < arr.GetLength(0); ++row)
    {
        for(int column = 0; column < arr.GetLength(1); ++column)
        {
            System.Console.Write($"{arr[row, column]}\t");
        }
        System.Console.WriteLine();
    }
}

void SwapRows(int[,] array)
{
    int rowCount = array.GetLength(0);
    for(int i=0; i<array.GetLength(1); ++i)
    {
        // array[0,i] <-> array[rowCount-1, i]
        int temp = array[0,i];
        array[0,i] = array[rowCount-1, i];
        array[rowCount-1, i] = temp;
    }
}

int[,] matrix = CreateMatrix(7, 6, 0, 100);
PrintMatrix(matrix);
System.Console.WriteLine();

SwapRows(matrix);
PrintMatrix(matrix);