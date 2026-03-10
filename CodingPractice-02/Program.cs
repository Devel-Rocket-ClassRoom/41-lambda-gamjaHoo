using System;

//Func<int> a = () => 1234;
//Func<int, int> square = x => x * x;
//Func<int, int, int> add = (a, b) => a+b;

//Console.WriteLine(a());
//Console.WriteLine(square(3));
//Console.WriteLine(add(3, 5));



////2
//Action a = () => Console.WriteLine("안녕하세요!");
//Action<string> b = (s) => Console.WriteLine(s);
//Action<string, int> c = (s, a) =>
//{
//    for (int i = 0; i < a; i++)
//    {
//        Console.WriteLine(s);
//    }
//};

//a();
//b("Hello, Lambda!");
//c("반복!", 3);



////3
//Func<int, int> a = delegate (int x) { return x * x; };
//Console.WriteLine(a(2));

//Func<int, int> lambda = x => x * x;
//Console.WriteLine(lambda(2));