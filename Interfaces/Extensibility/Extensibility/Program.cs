namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger(@"c:dbmigratortest\log.txt"));

            dbMigrator.Migrate();
        }
    }
}