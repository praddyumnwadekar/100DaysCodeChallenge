using System;
class LongestWordFinder {
  static void Main() {
    string input = Console.ReadLine();
    int max = 0;
    string result = string.Empty;
    
    foreach(var word in input.Split(' '))
    {
        if(max < word.Length)
        {
            max = word.Length;
            result = word;
        }    
    }
    Console.WriteLine("The Longest Word is: {0}",result);
  }
}
