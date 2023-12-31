﻿// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();

// функция заполнения массива
int[] GetRandomArray(int size) // тип данных, имя функции -массива- (размер массива)
{
    int[] array = new int [size]; // тип данных, имя массива = создай новый массив [с заданным размером]
    for (int i = 0; i < size; i++) // for(переменная счетчик = 0; пока 0 < размера массива; каждый цикл к 0 будем прибавлять + 1 )
    {                                       // в теле цикла
        array[i] = new Random().Next(-9, 10); // массив с индексом [счетчик "0"] = новое рандомное число. с  промежутком (-9,9)
    }
    return array;                            // возвращаем массив
}

int[] userArray = GetRandomArray(10); // тип данных, новая переменная которая = хранит в себе функцию с параметром(9) - то-есть "int size = 12" 

// вывод массива
void PrintArray(int[] arr) // функция void, имя функции, аргумент (массив arr)
{
    for (int i = 0; i < arr.Length; i++) // переменная счетчик = 0; пока 0 < длины массива arr; каждый цикл к 0 будем прибавлять + 1
    {
        System.Console.Write($"{arr[i]}, "); // выводим на консоль массив
    }
}

PrintArray(userArray); // вывызваем функцию void с параметром = (userArray = GetRandomArray = размер массива 12) = (int arr = 9)

// замена элементов

