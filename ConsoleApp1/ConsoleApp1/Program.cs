﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

static double GetAverage(int[] numery)
{
    double suma = 0;
    for (int i = 0; i < numery.Length; i++)
    {
        suma += numery[i];
    }

    return suma / numery.Length;
}

int[] arr = {1, 2, 3, 4};
double average = GetAverage(arr);
Console.WriteLine(average);

static int GetMax(int[]numbers)
{
    int max = numbers[0];
    for(int i = 0 ; i < numbers.Length ; i++)
    {
        if (max < numbers[i])
            max = numbers[i];
    }
    
    return max;
}
int[] numery = { 1, 2, 3, 4, 5, 6 };
int max = GetMax(numery);
Console.WriteLine(max);
