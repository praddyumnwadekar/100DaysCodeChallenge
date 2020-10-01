using System;
namespace Database_Connection
{   
    public class DbCommand
    {
        private string _command;
        private DatabaseConnection _databaseConnection;
        public DbCommand(string command,DatabaseConnection databaseConnection)
        {
            if(databaseConnection == null)
            {
                throw new NullReferenceException("DatabaseConnection is Required");
            }
            
            if(string.IsNullOrEmpty(command))
            {
                throw new ArgumentNullException("Command is Required");
            }

            this._command = command;
            this._databaseConnection = databaseConnection; 
        }
        
        private void Run()
        {
            Console.WriteLine($"The Command: \"{_command}\" run successfully.");
        }
        public void Execute()
        {
            _databaseConnection.Opening();
            Run();
            _databaseConnection.Closing();
        }
    }
}
