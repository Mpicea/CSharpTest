using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ToLower() : 소문자로 바꾸기
            Console.WriteLine("ABC".ToLower()); //abc

            //ToUpper() : 대문자로 바꾸기
            Console.WriteLine("ABC".ToUpper()); //ABC

            //Insert() : 앞의 인덱스 위치에 뒤의 값을 넣어라
            Console.WriteLine("Happy Friday!".Insert(5," Sunny")); //Happy Sunny Friday!

            //Remove() : 앞의 인덱스부터 뒤에 적힌 크기만큼 제거
            Console.WriteLine("I Don't Love You".Remove(2,6)); //I Love You

            //Trim() : 공백 제거
            Console.WriteLine("     ABC     "); //     ABC     
            Console.WriteLine("     ABC     ".Trim()); //ABC
        }
    }
}
