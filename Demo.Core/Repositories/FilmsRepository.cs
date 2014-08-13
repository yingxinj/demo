namespace Demo.Core.Repositories
{
    using Demo.Core.Models;
    using System.Collections.Generic;
    using System.Data.Entity;

    public interface IFilmsRepository : IRepository<Film>
    {
        IEnumerable<Film> GetEnglishFilms();
    }

    public class FilmsRepository : Repository<Film>, IFilmsRepository
    {
        public FilmsRepository(DbContext context) : base(context) {}

        public IEnumerable<Film> GetEnglishFilms()
        {
            var EnglishFilms = new List<Film>();
            foreach (var film in Entities)
            {
                if (film.Language.ToLower() == "english")
                {
                    EnglishFilms.Add(film);
                }
            }
            return EnglishFilms;
        }
    }
}