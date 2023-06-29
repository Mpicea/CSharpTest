using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             제약 : 50 이하의 정수가 입력됨을 가정합니다.﻿ 
1단계 
--------
N? 5
*
**
***
****
*****
2단계
N? 5
*****
****
***
**
*
3단계
N? 5
    *
   **
  ***
 ****
*****
4단계
N? 5
 *****
  ****
   ***
    **
     *
5단계 - 마름모
(홀수만가능)
N? 5
   *
  ***
 *****
  ***
   *
   */
            
            //값을 넣는 단계
            Console.WriteLine("양수의 숫자를 넣어주세요");
            int n = Int32.Parse(Console.ReadLine());

            star Star = new star();
            Star.firststar(n);
            Console.WriteLine();

            Star.secondstar(n);
            Console.WriteLine();

            Star.thirdstar(n);
            Console.WriteLine();

            Star.fourthstar(n);
            Console.WriteLine();

            Star.fifthstar(n);
        }
    }
    class star
    {
        public void firststar(int n)
        {
            //1단계
            for (int i = 0; i < n; i++) //그려질 줄의 수
            {
                for (int j = 0; j <= i; j++) //한 줄에 그려질 별의 수
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void secondstar(int n)
        {
            //2단계
            for (int i = n; i > 0; i--) //그려질 줄의 수
            {
                for (int j = 0; j < i; j++) //한 줄에 그려질 별의 수
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void thirdstar(int n)
        {
            //3단계
            for (int i = 0; i < n; i++) //그려질 줄의 수
            {
                for (int j = n - 1; j > i; j--) //맘에 안듬 //한 줄에 그려질 공백의 수
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++) //한 줄에 그려질 별의 수
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void fourthstar(int n)
        {
            //4단계
            for (int i = n; i > 0; i--) //그려질 줄의 수
            {
                for (int j = n; j > i; j--) //한 줄에 그려질 공백의 수
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++) //한 줄에 그려질 별의 수
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void fifthstar(int n)
        {
            for (int i = 1; i <= n; i++) //증가할때까지의 줄을 맡음
            {
                if (i % 2 == 1) //하지만 그 줄에서 홀수를 가진 줄만 표현
                {
                    for (int j = n; j > i; j--)//한 줄에 그려질 공백의 수
                    {
                        if (j % 2 == 1)//마름모를 위해 공백을 반으로 줄임
                        {
                            Console.Write(" ");
                        }
                    }
                    for (int j = 1; j <= i; j++) //한 줄에 그려질 별의 수
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            for (int i = n - 1; i > 0; i--) //맘에 안듬 //감소할때까지의 줄을 맡음
            {
                if (i % 2 == 1) //하지만 그 줄에서 홀수를 가진 줄만 표현
                {
                    for (int j = n; j > i; j--)//한 줄에 그려질 공백의 수
                    {
                        if (j % 2 == 1)//마름모를 위해 공백을 반으로 줄임
                        {
                            Console.Write(" ");
                        }
                    }
                    for (int j = 1; j <= i; j++)//한 줄에 그려질 별의 수
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
