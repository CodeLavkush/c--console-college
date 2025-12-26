using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_four
{
    //sub_c
    struct Employee
    {
        public int empId;
        public string empName;
        public double salary;

        public void Display()
        {
            Console.WriteLine("Employee ID: " + empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Salary: " + salary);
        }
    }
    class Program
    {
        // sub_a
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        static double Add(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            sub_c();
        }
        static void sub_a()
        {
            Console.WriteLine("Add two integers: " + Add(10, 20));
            Console.WriteLine("Add three integers: " + Add(10, 20, 30));
            Console.WriteLine("Add two doubles: " + Add(5.5, 4.5));

            Console.ReadLine();
        }
        static void sub_b()
        {
            Student s1 = new Student();
            Student s2 = new Student(101, "Alice");
            Student s3 = new Student(102, "Bob", 20);

            s1.Display();
            s2.Display();
            s3.Display();

            Console.ReadLine();
        }
        static void sub_c()
        {
            Employee e1;

            e1.empId = 1001;
            e1.empName = "John";
            e1.salary = 45000;

            e1.Display();

            Console.ReadLine();
        }
    }
    //sub_b
    class Student
    {
        int id;
        string name;
        int age;

        // Default constructor
        public Student()
        {
            id = 0;
            name = "Not Assigned";
            age = 0;
        }

        // Constructor with two parameters
        public Student(int i, string n)
        {
            id = i;
            name = n;
            age = 0;
        }

        // Constructor with three parameters
        public Student(int i, string n, int a)
        {
            id = i;
            name = n;
            age = a;
        }
        public void Display()
        {
            Console.WriteLine("ID: " + id + ", Name: " + name + ", Age: " + age);
        }
    }
}
