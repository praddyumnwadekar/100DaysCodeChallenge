using System;
class PrimeNumbersAdder {
  static void Main() {
      byte flag = 0;
      int sum = 0;
      
      Console.WriteLine("Enter The Number (until you want to add the primenumber): ");
      int input = Convert.ToInt32(Console.ReadLine());
      
      for(int i = 2;i <= input;i++)
      {
          flag = 0;
          for(int j = 2; j <= i/2;j++)
            {
              if(i % j == 0)
              {
                  flag = 1;
                  break;
              }
          }
         if(flag == 0 && input != 1)
              sum += i;
      }
      Console.WriteLine(sum);
  }
}
