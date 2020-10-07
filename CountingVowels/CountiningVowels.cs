using System;
using System.Collections.Generic;
using System.Text;

namespace LoopControls
{
    class CountiningVowels
    {
        public void  CountingTheNumbersOfVowels(string name) 
        {
            int count = 0;
            //string vowels = "aeiou";

            foreach (var item in name.ToLower())
            {
                if(item == 'a' || item == 'e'|| item == 'i' || item == 'o' || item == 'u') 
                {
                    count++;
                }
            }
            Console.WriteLine($"Vowels Count: {count}");
        }
    }
}
