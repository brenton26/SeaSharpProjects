using System;

namespace Interface_Extensibility
{

    public class DbMigrator
    {
        private readonly ILogger _logger;

        /*Any class that implements the ILogger interface can be used here.  This way, there is no coupling
         * between DbMigrator and that concrete class
         */
        public DbMigrator(ILogger logger) 
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo($"Migration started at {DateTime.Now}");

            // Details of migrating database

            _logger.LogInfo($"Migration finished at {DateTime.Now}");
        }
    }
}
