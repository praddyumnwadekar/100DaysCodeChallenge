using System;
using System.Collections.Generic;
using System.Text;

namespace LoopControls
{
    class ExerciseConsecutive
    {
        public static void Main()
        {
           Console.WriteLine("ENTER THE NUMBER IN (1-2-3-4-5) THIS FORMAT(HYPHEN)");
           var input= Console.ReadLine();

           List<int> numbers = new List<int>();

           foreach (var number in input.Split('-'))
               numbers.Add(Convert.ToInt32(number));
            
           numbers.Sort();                                          //for sorting the list.

           bool isConsecutive = true;
           for (int i = 0; i < numbers.Count; i++)
           { 
               if(numbers[i] != numbers[i - 1] + 1)
               {
                   isConsecutive = false;
                   break;
               }
           }
           Console.WriteLine(isConsecutive ? "Consecutive" : "Non Consecutive");
        }
    }
}
