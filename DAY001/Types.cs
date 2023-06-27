using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -10; //sbyte는 -가 존재하고 -128까지 가능함. -128~+127
            byte b = 255; //byte는 -를 쓸 수 없음. 0~255

            //Console.WriteLine($"a={a}");
            //Console.WriteLine("a = " + a);
            Console.WriteLine($"a={a}, b = {b}");

            short c = -32768; //-32768 ~ +32767 
            ushort d = 65535; //0~65535

            Console.WriteLine($"c={c}, d = {d}");

            int e = -2147483648; // -2147483648 ~ 22147483647
            uint f = 4294967295; // 0 ~ 4294967295

            Console.WriteLine($"e={e}, f = {f}");

            long g = -5000_0000_0000; //_ : 구분자, 정수 리터럴을 타이핑할때 사용 가능하다
            ulong h = 200_0000_0000_0000_0000;

            Console.WriteLine($"g={g}, h = {h}");

            byte i = 240; // 240-->10진수 리터럴
        }
    }
}
