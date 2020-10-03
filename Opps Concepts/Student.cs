using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConcept
{
    public class Student : Person,IPerson
    {
        public int StudentID { get; set; }
        public string CollegeName { get; set; }

        public Student()
        {
           Console.WriteLine("You are in Student Class");
        }

        public Student(int id)
        {
            this.StudentID = id;
        }

        public new void Show() {
            Console.WriteLine("YOU ARE IN STUDENT CLASS SHOW METHOD");
        }


        //public Student(string Name, string emailID,int id, string clg) : base(Name,emailID)
        //{
        //    this.StudentID = id;
        //    this.CollegeName = clg;
        //}

        //public new void ShowDetails() 
        //{
        //    base.ShowDetails();
        //    Console.WriteLine("StudentID : " + this.StudentID +" CollegeName: "+this.CollegeName);
        //}
    }
}
