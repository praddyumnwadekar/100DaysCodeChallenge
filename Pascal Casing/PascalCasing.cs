using System;
using System.Collections.Generic;
using System.Text;

namespace LoopControls
{
    class PascalCasing
    {
        public void ConvertStringIntoPascalCasing(string normal)
        {
            StringBuilder pascalString = new StringBuilder();

            foreach (var item in normal.Split(' '))
            {
                string s = item.Substring(0,1);
                pascalString.Append(s.ToUpper())
                            .Append(item.Substring(1).ToLower());
            }
            Console.WriteLine($"Pascal String:  {pascalString}");
        }
    }
}
