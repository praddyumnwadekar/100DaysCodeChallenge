/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
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