// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

static double GetAverage(int[] numbers)
{
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum / numbers.Length;
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
int[] numbers = { 1, 2, 3, 4, 5, 6 };
int max = GetMax(numbers);
Console.WriteLine(max);