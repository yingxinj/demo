namespace Demo.Core
{
    using Demo.Core.Models;
    using System.Data.Entity;

    public class DemoContext : DbContext
    {
        public DemoContext() : base("DefaultConnection") {}

        public DbSet<Kitten> Kittens { get; set; }

        public DbSet<Film> Films { get; set; }
    }
}
