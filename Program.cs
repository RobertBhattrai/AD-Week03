using System;

namespace Program
{
    class Operators
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return (double)a / b;
        }

        public void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
        }
    }

    class NullOperations
    {
        public void PerformNullCheck()
        {
            string username = null;
            // Ternary Operator
            string message = (username == null) ? "Username is not available" : username;
            Console.WriteLine($"Ternary Operator: {message}");

            // Null-Coalescing Operator
            string result = username ?? "Username is not available";
            Console.WriteLine($"Null-Coalescing Operator: {result}");

            // Null-Coalescing Assignment Operator
            username ??= "NewUser";
            Console.WriteLine($"After Null-Coalescing Assignment Operator: {username}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Task 1: Operators
            Console.WriteLine("Assignment of Week03");
            Console.WriteLine("Operator, Contol Flow and Exception Handling");

            //Creating Object of Operators Class
            Operators ops = new Operators();
            Console.WriteLine("Operators Task Results");
            Console.WriteLine("Addition: " + ops.Add(10, 5));
            Console.WriteLine("Subtraction: " + ops.Subtract(10, 5));
            Console.WriteLine("Multiplication: " + ops.Multiply(10, 5));
            Console.WriteLine("Division: " + ops.Divide(10, 5));

            //Odd Even Finder
            Console.Write("Odd Even Finder for number 7: ");
            ops.OddEvenFinder(7);
            Console.WriteLine();

            // Task 2: Null Operations
            Console.WriteLine("Null Operations Task Results");
            NullOperations nullOps = new NullOperations();
            nullOps.PerformNullCheck();

            //Task 3: If else and switch
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age < 20)
            {
                Console.WriteLine("Teenager");
            }
            else if (age >= 20)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Invalid age");
            }

            // Task 4: Switch for Days of Week
            Console.WriteLine("Task 4: Day of Week");
            Console.Write("Enter a number (1-7): ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                break;
                case 2:
                    Console.WriteLine("Monday");
                break;
                case 3:
                    Console.WriteLine("Tuesday");
                break;
                case 4:
                    Console.WriteLine("Wednesday");
                break;
                case 5:
                    Console.WriteLine("Thursday");
                break;
                case 6:
                    Console.WriteLine("Friday");
                break;
                case 7:
                    Console.WriteLine("Saturday");
                break;
                default:
                    Console.WriteLine("Invalid day number");
                break; 
            }
        }  
    }
}