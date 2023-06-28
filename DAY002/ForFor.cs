using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            for(int i = 0; i < 25; i++) //25번 반복
            {
                cnt++;
            }
            Console.WriteLine(cnt);

            cnt = 0;
            //5*5=25번 반복
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
