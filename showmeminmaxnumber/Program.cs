using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[5];

            for(int i = 0; i < input.Length; i++)
            {
                Console.Write("숫자를  입력해주세요 : ");
                input[i] = int.Parse(Console.ReadLine());
            }
            

            var max = 0;
            var min = input[1];

            for(int i = 0; i < input.Length; i++)
            {
                if (max < input[i])
                {
                    max = input[i];
                }
                if (min > input[i])
                {
                    min = input[i];
                }
            }


            Console.WriteLine("-------------------------------------");
            Console.WriteLine("가장 큰 수 : "+max);
            Console.WriteLine("가장 작은 수 : " + min);

        }
    }
}
