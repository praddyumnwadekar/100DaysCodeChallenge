using System;

namespace Database_Connection

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var sqC = new SqlConnection("Sql Connection", new TimeSpan(0, 0, 5));                       // Sql Connection
                sqC.Opening();
                sqC.Closing();

            //    var Orc = new OracleConnection("Oracle Connection", new TimeSpan(0, 0, 16));                // Oracle Connection.
              //  Orc.Opening();
                //Orc.Closing();
                
                DbCommand dbCommand = new DbCommand("select * from Students", sqC);
                dbCommand.Execute();


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
         
        }
    }
}
