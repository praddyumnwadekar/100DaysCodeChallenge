using System;

namespace Database_Connection
{
    class OracleConnection : DatabaseConnection
    {
        public OracleConnection(string connection, TimeSpan time) : base(connection,time)
        {
        }

        public override void Opening()
        {
            Console.WriteLine("Oracle Connction is Opening");
        }
        public override void Closing()
        {
            Console.WriteLine("Oracle Connection is Closing");
        }
    }
}
