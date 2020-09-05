using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 1:
            int number1;
            int number2;
            Console.Write("NHập số thứ nhất: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("UCLN: {0}", UCLN(number1, number2));



            //Bài 2:
            int N = 1000;
            bool[] check = new bool[N + 1];
            // Khởi tạo tất cả các số [2...N] đều là số nguyên tố
            for (int i = 2; i <= N; i++)
            {
                check[i] = true;
            }
            // Thuật toán sàng nguyên tố
            // Nếu một số là số nguyên tố, thì tất cả các bội của nó không phải số nguyên tố
            for (int i = 2; i <= N; i++)
            {
                if (check[i] == true)
                {
                    for (int j = 2 * i; j <= N; j += i)
                    {
                        check[j] = false;
                    }
                }
            }
            // In ra các số là số nguyên tố
            for (int i = 2; i <= N; i++)
            {
                if (check[i] == true)
                {
                    Console.WriteLine(i + " ");
                }
            }
            Console.ReadKey();
        }
        

        static int UCLN(int A, int B)
        {
            if (B == 0)
                return A;
            return UCLN(B, A % B);
        }
    }
}
