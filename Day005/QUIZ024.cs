using System;

namespace QUIZ024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
Q. 로또번호 구하기가 완성이 되면 달팽이 배열에 도전해 보세요.
﻿단 정수값은 20이하의 양의 정수만 입력하세요. 
----------------------------------------------------------------
N ? 5

1   2   3   4   5

16  17  18  19  6

15  24  25  20  7

14  23  22  21  8
 
13  12  11  10  9
             */
            Console.Write("달팽이 형식 증가 배열을 만들려고 한다.\n " +
                "N*N크기의 배열에서 N의 크기(정수)를 입력하시오 (0<N<=20): ");
            int n = Int32.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];
            snail(ref arr, arr.GetLength(0), 0, 0, 0);

            //출력
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //달팽이 형식 배열값 넣는 메소드
        static int[,] snail(ref int[,] arr, int Length, int dire, int x, int y)
        {
            if (Length != 0)
            {
                //방향을 나타내는 배열
                int[] col = { 1, 0, -1, 0 };
                int[] row = { 0, 1, 0, -1 };

                //초기값 넣기
                if (arr[0, 0] != 1)
                {
                    arr[0, 0] = 1;
                    x = 0;
                    y = 0;
                }

                //한 줄에 값을 넣기
                switch (dire)
                {
                    case 0: //오른쪽 방향

                        for (int i = 0; i < Length - 1; i++)
                        {
                            //인덱스 위치
                            x = x + col[dire];
                            y = y + row[dire];
                            //값 넣기

                            arr[y, x] = arr[y, x - 1] + 1;
                        }
                        if (y == 0) //진짜 진짜 진짜 엄청 맘에 안듬
                        {
                            return snail(ref arr, Length, (dire + 1) % 4, x, y);
                        }
                        return snail(ref arr, Length - 1, (dire + 1) % 4, x, y);
                    //break;
                    case 1: //아래 방향

                        for (int i = 0; i < Length - 1; i++)
                        {
                            //인덱스 위치
                            x = x + col[dire];
                            y = y + row[dire];
                            //값 넣기

                            arr[y, x] = arr[y - 1, x] + 1;
                        }

                        return snail(ref arr, Length, (dire + 1) % 4, x, y);
                    //break;
                    case 2: //왼쪽 방향

                        for (int i = 0; i < Length - 1; i++)
                        {
                            //인덱스 위치
                            x = x + col[dire];
                            y = y + row[dire];
                            //값 넣기

                            arr[y, x] = arr[y, x + 1] + 1;
                        }

                        return snail(ref arr, Length - 1, (dire + 1) % 4, x, y);

                    case 3: //위쪽 방향

                        for (int i = 0; i < Length - 1; i++)
                        {
                            //인덱스 위치
                            x = x + col[dire];
                            y = y + row[dire];
                            //값 넣기

                            arr[y, x] = arr[y + 1, x] + 1;
                        }

                        return snail(ref arr, Length, (dire + 1) % 4, x, y);
                }
            }
            return arr;
        }
    }
}
