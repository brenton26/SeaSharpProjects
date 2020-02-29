using System;

namespace nameDbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to connect to a SQL database or an Orcale database? ");
            Console.Write("Enter 1 for SQL or 2 for Oracle: ");
            string user_input = Console.ReadLine();
            if (user_input != "1" && user_input != "2") { Environment.Exit(420); }
            Console.Write("Input configuration string: ");
            string user_conn_input = Console.ReadLine();
            if (user_input == "1")
            {
                Console.WriteLine("\nPlease type your command.");
                Console.Write(">>> ");
                string user_command = Console.ReadLine();
                var conn = new SqlConnection(user_conn_input);
                var command = new DbCommand(conn, user_command);
                command.Execute();
            }
            if (user_input == "2")
            {
                Console.WriteLine("\nPlease type your command.");
                Console.Write(">>> ");
                string user_command = Console.ReadLine();
                var conn = new OracleConnection(user_conn_input);
                var command = new DbCommand(conn, user_command);
                command.Execute();
            }
        }
    }
    public abstract class DbConnection
    {
        public DbConnection(string connection_string)
        {
            if (connection_string.Trim() == "")
            {
                throw new InvalidOperationException("This connection requires a connection string to be in a valid state.");
            }
            this.ConnectionString = connection_string;
        }
        private string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connection_string) : base(connection_string) { }
        public override void OpenConnection()
        {
            Console.WriteLine("SqlConnection: connected.");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("SqlConnection: disconnected.");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connection_string) : base(connection_string) { }
        public override void OpenConnection()
        {
            Console.WriteLine("OracleConnection: connected.");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("OracleConnection: disconnected.");
        }
    }

    public class DbCommand
    {
        public DbCommand(DbConnection conn, string instruction)
        {
            this.Connection = conn;
            this.Instruction = instruction;
        }
        private DbConnection Connection { get; set; }
        public string Instruction { get; set; }

        public void Execute()
        {
            Connection.OpenConnection();
            Console.WriteLine("Executing the following instruction: " + Instruction);
            Connection.CloseConnection();
        }
    }

}
