using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConcept
{

    interface IPerson
    {
         void Show();
        public int ID { get; set; }
    }

    public class Person : IPerson
    {
        public int ID {
            get;
            set;
        }

        //public string Name { get; set; }
        //public string EmailID { get; set; }

        public Person()
        {
            Console.WriteLine("You are in Base Class");
        }
        //public Person(string name,string emailid)
        //{
        //    this.Name = name;
        //    this.EmailID = emailid;
        //}

        //public virtual void ShowDetails()
        //{
        //    Console.WriteLine($"NAME: {this.Name}  EmailID: {this.EmailID}");
        //}

        //public void Show(params int[] p)
        //{
        //    foreach (var item in p)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        public void Show()
        {
            Console.WriteLine("we are in \"Person\" Class and implement show method");
        }
    }
}
