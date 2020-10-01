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

                var Orc = new OracleConnection("Oracle Connection", new TimeSpan(0, 0, 8));                // Oracle Connection.
                Orc.Opening();
                Orc.Closing();
                
                DbCommand dbCommandSql = new DbCommand("select * from Students", sqC);
                dbCommandSql.Execute();
                
                DbCommand dbCommandOracle = new DbCommand("select * from Students", Orc);
                dbCommandOracle.Execute();


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
         
        }
    }
}
