﻿// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

Console.Clear();

int[] GetRandomArray(int start, int end, int length)
{
    int[] array = new int [size]; 
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}




int[] userArray = GetRandArray(9);