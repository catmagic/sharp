// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите минимальное число диапазона чисел в массиве: ");
int maxValue = Prompt("Введите минимальное число диапазона чисел в массиве: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
int[] resSum = GetSumm(array);
Console.WriteLine($"Сумма положительных чисел = {resSum[0]}, сумма отрицательных чисел = {resSum[1]}");


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);

    }
    return result;
}

void PrintArray(int[] arr)
{
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     Console.Write($"{arr[i]} ");
    // }
    foreach (int el in arr)
    {
        Console.Write($"{el} ");
    }
}

int[] GetSumm(int[] array)
{

    int[] result = new int[2];

    foreach (int el in array)
    {
        if (el > 0) result[0] += el;
        if (el < 0) result[1] += el;
    }
    return result;
}
