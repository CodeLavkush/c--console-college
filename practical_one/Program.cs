using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_one
{
    class Program
    {
        static void Main(string[] args)
        {
            sub_c();
        }
        static void sub_a()
        {
            int num, result = 1;

            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Enter " + i + " no: ");
                num = Convert.ToInt32(Console.ReadLine());
                result *= num;
            }

            Console.WriteLine("Product is " + result);
            Console.ReadLine();
        }
        static void sub_b()
        {
            int[] numArr = { 5, 6, 3, 4, 1, 2 };
            string[] strArr = { "Ram", "SHYAM", "Sam" };

            // 1. print array
            void PrintArray(int[] arr)
            {
                foreach (int n in arr)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
            Console.Write("Original array: ");
            PrintArray(numArr);

            // 2. Length
            Console.WriteLine("Length is: " + numArr.Length);

            // 3. sort array
            Array.Sort(numArr);
            Console.Write("Sorted Array: ");
            PrintArray(numArr);

            // 4. revers array
            Array.Reverse(numArr);
            Console.Write("Reversed Array: ");
            PrintArray(numArr);

            // 5. index of 4
            int index = Array.IndexOf(numArr, 4);
            Console.WriteLine("Index of 4: " + index);

            // 6. max
            Console.WriteLine("Maximum value: " + numArr.Max());

            // 7. min 
            Console.WriteLine("Minimum value: " + numArr.Min());

            // 8. get value 
            Console.WriteLine("Value at index 2: " + numArr.GetValue(2));

            // 9. set value
            numArr.SetValue(12, 2);
            Console.WriteLine("Updated value at index 2: " + numArr.GetValue(2));

            // 10. copy array
            int[] copyArr = new int[numArr.Length];
            Array.Copy(numArr, copyArr, numArr.Length);
            Console.Write("Copyed array: ");
            PrintArray(copyArr);

            Console.ReadLine();
        }
        static void sub_c()
        {
            string str = "  Hello World  ";

            // 1. Length
            Console.WriteLine("Length: " + str.Length);

            // 2. ToUpper
            Console.WriteLine("ToUpper: " + str.ToUpper());

            // 3. ToLower
            Console.WriteLine("ToLower: " + str.ToLower());

            // 4. Trim
            Console.WriteLine("Trim: '" + str.Trim() + "'");

            // 5. Substring
            Console.WriteLine("Substring (0,5): " + str.Substring(2, 5));

            // 6. Replace
            Console.WriteLine("Replace: " + str.Replace("World", "C#"));

            // 7. Contains
            Console.WriteLine("Contains 'Hello': " + str.Contains("Hello"));

            // 8. IndexOf
            Console.WriteLine("IndexOf 'o': " + str.IndexOf('o'));

            // 9. StartsWith
            Console.WriteLine("StartsWith '  He': " + str.StartsWith("  He"));

            // 10. EndsWith
            Console.WriteLine("EndsWith '  ': " + str.EndsWith("  "));

            Console.ReadLine();
        }
    }
}
