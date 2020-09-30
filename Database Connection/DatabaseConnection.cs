using System;

namespace Database_Connection
{
    abstract class DatabaseConnection
    {
        private readonly TimeSpan _time = new TimeSpan(
            0,0,10);
        public DatabaseConnection(string connection,TimeSpan time)
        {
           
            if (string.IsNullOrEmpty(connection))
                throw new ArgumentNullException();
            this.ConnectionString = connection;
            this.Timeout = time;
           
            
        }
        private string ConnectionString { get; set; }
        private TimeSpan Timeout {
            set
            {
                if (value > _time)
                {
                    throw new TimeoutException();
                }
            }
        }

        public abstract void Opening();
        abstract public void Closing();            
    }
}
