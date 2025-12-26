using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            sub_c();
        }
        static void sub_a()
        {
            int n1 = 0, n2 = 1, n3;
            int count;

            Console.Write("Enter number of terms: ");
            count = Convert.ToInt32(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " ");

            for (int i = 3; i <= count; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");

                n1 = n2;
                n2 = n3;
            }

            Console.ReadLine();
        }
        static void sub_b()
        {
            int start, end;
            bool isPrime;

            Console.Write("Enter starting number: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter ending number: ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers between " + start + " and " + end + " are:");

            for (int num = start; num <= end; num++)
            {
                if (num < 2)
                    continue;

                isPrime = true;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.Write(num + " ");
            }

            Console.ReadLine();
        }
        static void sub_c()
        {
            int num, reverse = 0, sum = 0, digit;

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            int temp = num;

            while (temp > 0)
            {
                digit = temp % 10;
                reverse = reverse * 10 + digit;
                sum += digit;
                temp /= 10;
            }

            Console.WriteLine("Reverse of the number: " + reverse);
            Console.WriteLine("Sum of digits: " + sum);

            Console.ReadLine();
        }
    }
}
