using System;
using System.Text;





Func<string, string> toUpper = value => value.ToUpper();
Console.Write("[대문자 변환] hello world -> ");
ApplyAndPrint("hello world", toUpper);


Func<string, string> mask = value =>
{
    StringBuilder sb = new StringBuilder();
    sb.Append(value.Substring(0, 2));
    sb.Append("***");
    //for(int i = 0; i < value.Length-2; i++)
    //{
    //    sb.Append('*');
    //}
    return sb.ToString();
};
Console.Write("[마스킹 처리] ");
ApplyAndPrint("SecretCode", mask);

Func<string, string> greet = value =>
{
    StringBuilder sb = new StringBuilder();
    sb.Append("안녕하세요, ");
    sb.Append(value);
    sb.Append("님!");
    return sb.ToString();
};
Console.Write("[인사말 생성]");
ApplyAndPrint("민수", greet);

static void ApplyAndPrint(string input, Func<string, string> formatter)
{
    Console.WriteLine(formatter(input));
}