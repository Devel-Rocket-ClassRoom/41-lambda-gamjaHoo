using System;
using System.Collections.Generic;

////1
//var multiplesOf3 = FindNumbers(n => n % 3 == 0);
//Console.WriteLine("3의 배수:");
//foreach (var n in multiplesOf3)
//{
//    Console.Write($"{n} ");
//}
//Console.WriteLine();

//var perfectSquares = FindNumbers(n =>
//{
//    int sqrt = (int)Math.Sqrt(n);
//    return sqrt * sqrt == n;
//});

//Console.WriteLine("제곱수:");
//foreach (var n in perfectSquares)
//{
//    Console.Write($"{n} ");
//}

//static List<int> FindNumbers(Predicate<int> predicate)
//{
//    List<int> results = new List<int>();
//    for(int i = 1; i <100; i++)
//    {
//        if(predicate(i)) results.Add(i);
//    }
//    return results;
//}



////2
//Predicate<int> isEven = x => x % 2 == 0;
//Func<int, bool> isOdd = x => x % 2  != 0;

//Console.WriteLine(isEven(2));
//Console.WriteLine(isOdd(2));



////3
//int factor = 2;
//Func<int, int> multiplier = n => factor * n;

//Console.WriteLine(multiplier(3));
//factor = 10;
//Console.WriteLine(multiplier(3));



////4
//int count = 0;
//Action increment = () => count++;
//increment();
//increment();
//increment();
//Console.WriteLine(count);



////5
//var counter = CreateCounter();
//Console.WriteLine(counter());
//Console.WriteLine(counter());
//Console.WriteLine(counter());
//static Func<int> CreateCounter()
//{
//    int count = 0;
//    return () => count++;
//}