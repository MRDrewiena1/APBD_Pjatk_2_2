// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");


Console.WriteLine("Hello, World!");

static double CalculateAverage(int[] values)
{
    var sum = 0.0;
    var count = values.Length;
    foreach(var i in values)
    {
        sum += i;
    }
    return sum / count;
}

static int CalculateMax(int[] values)
{
    var currMax = values[0];
    foreach (var i in values)
    {
        if (currMax < i)
        {
            currMax = i;
        }
    }
    return currMax;
}

static int CalculateMin(int[] values)
{
    var currMin = values[0];
    foreach (var i in values)
    {
        if (currMin > i)
        {
            currMin = i;
        }
    }
    return currMin;
}

int[] testVal = [2,535,3,4,1,4,5,7,6,91,342,67];
Console.WriteLine(CalculateAverage(testVal));
Console.WriteLine(CalculateMax(testVal));
Console.WriteLine(CalculateMin(testVal));