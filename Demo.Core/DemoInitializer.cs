namespace Demo.Core
{
    using Demo.Core.Migrations;
    using System.Data.Entity;

    public class BattleshipsInitializer : MigrateDatabaseToLatestVersion<DemoContext, Configuration> {}
}
