using System;
using System.Collections.Generic;
using System.Text;

namespace LoopControls
{
    class ExerciseFB
    {
        public static void Main()
        {
           List<string> names = new List<string>();
           int count = 0;
           string name;

           while (true)
           {
               name = Console.ReadLine();
                
               if (name.Equals(""))
                   break;
                
               names.Add(name);
           }
          
           if (names.Count > 3)
           {
               count = 3;
           } 
         
           switch (count)
           {

               case 0:
                   break;
               case 1:
                   Console.WriteLine("{0} Likes your post", names[0]);
                   break;
               case 2:
                   Console.WriteLine("{0} and {1} Likes your post", names[0],names[1]);
                   break;
               case 3:
                   Console.WriteLine("{0},{1} and {2}", names[0], names[1], (names.Count) - 2);
                   break;
           }
        }
    }
}
