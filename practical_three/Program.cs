using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_three
{
    class Program
    {
        // Step 1: Declare a delegate
        delegate int MyDelegate(int a, int b);
        // Step 2: Define methods with same signature
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            sub_c();
        }
        static void sub_a()
        {
            char ch;

            Console.Write("Enter a character: ");
            ch = Convert.ToChar(Console.ReadLine());

            switch (char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine(ch + " is a vowel");
                    break;

                default:
                    Console.WriteLine(ch + " is not a vowel");
                    break;
            }

            Console.ReadLine();

        }
        static void sub_b()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Elements in the array are:");

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
        static void sub_c()
        {
            // Step 3: Create delegate instance and assign method
            MyDelegate del = Add;
            Console.WriteLine("Addition: " + del(10, 20));

            // Assign another method to the same delegate
            del = Multiply;
            Console.WriteLine("Multiplication: " + del(10, 20));

            Console.ReadLine();
        }
    }
}
