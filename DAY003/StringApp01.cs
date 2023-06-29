using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//usting static System.Console; : Console이 축약이 됨

namespace StringApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            Console.WriteLine(greeting);
            Console.WriteLine();

            //IndexOf() : 현재 문자열 내에서 앞에서 위치 찾기(맨 처음)
            Console.WriteLine($"{greeting.IndexOf("Good")}"); //0
            Console.WriteLine($"{greeting.IndexOf("o")}"); //1

            Console.WriteLine($"{greeting.IndexOf("Morning")}"); //5
            Console.WriteLine($"{greeting.IndexOf("d")}"); //3

            //LastIndexOf() : 현재 문자열 내에서 뒤에서 위치 찾기(맨 마지막)
            Console.WriteLine($"{greeting.LastIndexOf("Good")}"); //0
            Console.WriteLine($"{greeting.LastIndexOf("o")}"); //6

            //StartsWith() : 이 단어로 시작하는가?
            //Console.WriteLine($"{}");
            Console.WriteLine($"StartsWith : {greeting.StartsWith("Good")}"); //True
            Console.WriteLine($"StartsWith : {greeting.StartsWith("Morning")}"); //False

            //EndsWith() : 이 단어로 끝나는가?
            Console.WriteLine($"EndsWith : {greeting.EndsWith("Morning")}"); //True
            Console.WriteLine($"EndsWith : {greeting.EndsWith("Good")}"); //False

            //Contains() : 포함하는가?
            Console.WriteLine($"Contains : {greeting.Contains("Morning")}"); //True
            Console.WriteLine($"Contains : {greeting.Contains("Good")}"); //True

            //Replace() : 앞의 문자열을 뒤의 문자열로 바꿔라
            Console.WriteLine($"Replace Evening: {greeting.Replace("Morning", "Evening")}"); //Good Evening
        }
    }
}
