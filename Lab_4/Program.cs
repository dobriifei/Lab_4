using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            uint n= (uint)Convert.ToInt32(Console.ReadLine());
            for (uint i = 1, kv=i; i <= n; ++i,kv=kv+2*i-1)
            {
                Console.WriteLine("квадрат числа {0} равен{1}", i, kv);
                Console.ReadKey();
            }


        }
    }
}
