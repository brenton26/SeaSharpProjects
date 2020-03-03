using System;

namespace Interface_Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Using an interface, we can can use either ConsoleLogger or FileLogger. Both
             * classes inherit from the same interface.
             */
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
        }
    }
}
