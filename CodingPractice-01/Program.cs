using System;

////1

//    PrintMessage pm = () => Console.WriteLine("안녕하세요.");

//pm();

//    delegate void PrintMessage();



////2
//Transformer t = x => x * x;
//Console.WriteLine(t(3));
//Console.WriteLine(t(4));

//delegate int Transformer(int a);



////3
//IsLonger isLonger = (string msg, int len) => msg.Length > len;

//Console.WriteLine(isLonger("안녕하세요.", 5));
//Console.WriteLine(isLonger("반갑습니다.", 10));


//delegate bool IsLonger(string s, int i);



////4
//Greeting greet = () =>
//{
//    Console.WriteLine("안녕하세요.");
//    Console.WriteLine("반갑습니다.");
//};

//greet();

//delegate void Greeting();



////5
//Calculator calculator = (a, b) => a + b;
//int a = 3;
//int b = 5;

//Console.WriteLine($"{a} + {b} = {calculator(a, b)}");
//Console.WriteLine($"합계: {calculator(a, b)}");

//delegate int Calculator(int a, int b);