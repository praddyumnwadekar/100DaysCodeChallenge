using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConcept
{
    public class Employee : Person, IPerson
    {
        public Employee()
        {
        }

        public new void Show()
        {
            Console.WriteLine("You are in Employee Class");
        }
    }
}
