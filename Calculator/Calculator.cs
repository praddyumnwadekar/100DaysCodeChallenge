using System;
using System.ComponentModel;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int num1, num2, ch, result = 0;
            string ans;
            Calculator c = new Calculator();

            Console.WriteLine("Enter Two Numbers: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("1 - Addition\t2 - Subtraction\t3 - Multiplicationt\t4 - Division\nEnter Your Choice: ");
                ch = int.Parse(Console.ReadLine());



                switch (ch)
                {
                    case 1:
                        c.Addition(num1, num2);
                        break;
                    case 2:
                        result = c.Substraction(num1, num2);
                        Console.WriteLine("The Substraction of {0} and {1} is {2}", num1, num2, result);
                        break;
                    case 3:
                        c.Multiplication(num1, num2, out result);
                        Console.WriteLine("The Multiplication of {0} and {1} is {2}", num1, num2, result);
                        break;
                    case 4:
                        c.Division(num1, num2, out result);
                        Console.WriteLine("The Multiplication of {0} and {1} is {2}", num1, num2, result);
                        break;

                    default:
                        break;

                }
                Console.WriteLine("Do You Want to do an Operation(Yes/No): ");
                ans = Console.ReadLine().ToUpper(); 
            } while (ans == "YES");
        }

        public void Addition(int a,int b)
        {
            
            Console.WriteLine("The Addition of {0} and {1} is {2}",a,b,a + b);
        }

        public int Substraction(int a, int b)
        {
           
            return(a - b);
        }

        public void Multiplication(int a,int b,out int rs)
        {
            rs = a * b;

        }

        public void Division(int a, int b, out int rs)
        {
            rs = a / b;

        }

                
    }


}
