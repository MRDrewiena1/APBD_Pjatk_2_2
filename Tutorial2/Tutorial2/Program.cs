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