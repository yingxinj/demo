namespace Demo.Core.Repositories
{
    using Demo.Core.Models;
    using System.Data.Entity;

    public interface IFilmsRepository : IRepository<Film> {}

    public class FilmsRepository : Repository<Film>, IFilmsRepository
    {
        public FilmsRepository(DbContext context) : base(context) {}
    }
}
