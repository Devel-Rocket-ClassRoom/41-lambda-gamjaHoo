using System;


int[] numbers = { 10, 25, 7, 42, 18, 33 };

int sum = ProcessArray(numbers, (a) =>
{
    int s = 0;
    for(int i = 0; i < a.Length; i++)
    {
        s += a[i];
    }
    return s;
});

int big = ProcessArray(numbers, (a) =>
{
    int b = -1;
    for (int i = 0; i < a.Length; i++)
    {
        if(a[i] > b) b = a[i];
    }
    return b;
});

int small = ProcessArray(numbers, (a) =>
{
    int s = 99999;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] < s) s = a[i];
    }
    return s;
});

int countEven = ProcessArray(numbers, (a) =>
{
    int c = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] %2 == 0)
        {
            c++; 
        }
    }
    return c;
});
Console.Write("배열: ");
for(int i =  0; i < numbers.Length; i++)
{
    if(i != 0)
    {
        Console.Write($", {numbers[i]}");
    }
    else
    {
        Console.Write(numbers[i]);
    }
    
}
Console.WriteLine();
Console.WriteLine($"합계: {sum}");
Console.WriteLine($"최댓값: {big}");
Console.WriteLine($"최솟값: {small}");
Console.WriteLine($"짝수 개수: {countEven}");


int ProcessArray(int[] data, Func<int[], int> processor)
{
    return processor(data);
}