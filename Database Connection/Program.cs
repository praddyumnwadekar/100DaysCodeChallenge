using System;

namespace Database_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var sqC = new SqlConnection("Hiii", new TimeSpan(0, 0, 5));
                sqC.Opening();
                sqC.Closing();

                var Orc = new OracleConnection("123", new TimeSpan(0, 0, 16));
                Orc.Opening();
                Orc.Closing();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
         
        }
    }
}
