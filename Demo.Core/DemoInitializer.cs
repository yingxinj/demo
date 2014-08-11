namespace Demo.Core
{
    using Demo.Core.Migrations;
    using System.Data.Entity;

    public class DemoInitializer : MigrateDatabaseToLatestVersion<DemoContext, Configuration> {}
}
