using System;

namespace Database_Connection
{
    class SqlConnection : DatabaseConnection
    {
        public SqlConnection(string connection,TimeSpan time) : base(connection,time)
        {

        }


        public override void Opening()
        {
            Console.WriteLine("Sql Connection is Opening");
        }
        public override void Closing()
        {
            Console.WriteLine("Sql Connection is Closing");
        }
    }
}
