// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Feature1");
Console.WriteLine("Feature2");
Console.WriteLine("Hi");
int[] array = { 12, 53, 69, 22, 329 };
Console.WriteLine(CalculateMax(array));


static double CalculateMax(int[] values)
{
    int max = values[0];
    
    for (int i = 0; i < values.Length; i++)
    {
        if (values[i] > max)
        {
            max = values[i];
        }
    }
    return max;
}