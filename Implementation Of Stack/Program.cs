using System;

namespace ImplementationOfStack
{
    class Program
    {
        static void Main(string[] args)
        {

     
            
            var stack = new Stack();

            stack.Push(123);
            stack.Push(124);
            stack.Push(125);
            stack.Push(null);

            object j =  stack.Pop();
            object j1 = stack.Pop();
            Console.WriteLine($"Popped Element: {j}");
            Console.WriteLine($"Popped Element: {j1}");

            stack.Display();
        }
    }
}
