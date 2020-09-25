
using System;
using System.Collections.Generic;


namespace ImplementationOfStack
{
    public class Stack
    {

        private int _top;
        private readonly List<object> list = new List<object>();


        public void Push(object o)
        {
                
            if (o == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                _top++;
                list.Add(o);
            }
            
           
            
        }

        public object Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                object l = list[_top - 1];
                list.RemoveAt(_top - 1);
                _top--;
                return l;
            }
        }        


        public void Clear()
        {
            list.Clear();
            System.Console.WriteLine("Remove Successfully");
        }
        public void Display()
        {
            System.Console.WriteLine("Stack Elements: ");
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
