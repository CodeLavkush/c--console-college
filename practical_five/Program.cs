using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_five
{
    //sub_a
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    // Derived class (Child)
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
    //sub_b
    // Base class (Level 1)
    class Electronics
    {
        public void PowerOn()
        {
            Console.WriteLine("Electronics device is powered on");
        }
    }

    // Derived class (Level 2)
    class Phone : Electronics
    {
        public void MakeCall()
        {
            Console.WriteLine("Phone is making a call");
        }
    }

    // Derived class (Level 3)
    class Smartphone : Phone
    {
        public void BrowseInternet()
        {
            Console.WriteLine("Smartphone is browsing the internet");
        }
    }
    // sub_c
    // First interface
    interface IPrinter
    {
        void Print();
    }

    // Second interface
    interface IScanner
    {
        void Scan();
    }

    // Class implementing multiple interfaces
    class MultiFunctionMachine : IPrinter, IScanner
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sub_d();
        }
        static void sub_a()
        {
            // Create object of derived class
            Dog d = new Dog();

            // Access method of base class
            d.Eat();

            // Access method of derived class
            d.Bark();

            Console.ReadLine();
        }
        static void sub_b()
        {
            Smartphone sp = new Smartphone();
            // Access methods from all levels
            sp.PowerOn();        // Base class
            sp.MakeCall();       // Intermediate class
            sp.BrowseInternet(); // Derived class

            Console.ReadLine();
        }
        static void sub_c()
        {
            MultiFunctionMachine mfm = new MultiFunctionMachine();

            mfm.Print();
            mfm.Scan();

            Console.ReadLine();
        }
        static void sub_d()
        {
            int a, b, result;

            try
            {
                Console.Write("Enter first number: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                b = Convert.ToInt32(Console.ReadLine());

                // This may cause divide by zero exception
                result = a / b;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input! Please enter numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution of try-catch block is complete.");
            }

            Console.ReadLine();
        }
    }
}
