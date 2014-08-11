namespace Demo.Web.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class FilmsListViewModel
    {
        public IEnumerable<string> Names { get; set; }

        public int TotalNumber
        {
            get { return Names.Count(); }
        }
    }
}
