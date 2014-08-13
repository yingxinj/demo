namespace Demo.Web.Models
{
    using System.Collections.Generic;

    public class EnglishFilmsViewModel
    {
        public EnglishFilmsViewModel(Dictionary<string, int> filmPrices)
        {
            FilmPrices = filmPrices;
            foreach (var film in FilmPrices)
            {
                TotalPrice += film.Value;
            }
        }

        public int TotalPrice { get; set; }
        public Dictionary<string, int> FilmPrices { get; set; }
    }
}