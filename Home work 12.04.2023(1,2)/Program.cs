using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_12._04._2023_1_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4-значное число: ");
            string input = Console.ReadLine();
            for (int i = input.Length- 1; i >= 0; i--)
            {
                Console.WriteLine(input[i]);
            }
            Console.ReadKey();

            string input1;
            int tmp;
            Console.WriteLine("Введите 6-значное число: ");
            input1 = Console.ReadLine();
            try
            {
                for (int i = 0;i < input1.Length; i++)
                {
                    tmp = int.Parse(input1[i].ToString());
                    if (tmp % 2 == 0)
                    {
                        Console.WriteLine(tmp);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Неправильный ввод!!");
            }
           
            Console.ReadKey();
        }
    }
}
