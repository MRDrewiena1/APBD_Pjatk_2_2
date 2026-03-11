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

int[] val = [2,3,4,1,4,5];
Console.WriteLine(CalculateAverage(val));