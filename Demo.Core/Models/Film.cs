namespace Demo.Core.Models
{
    using System;

    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PriceInPence { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public int Length { get; set; }
        public DateTime TimeUpdated { get; set; }
        public string Description { get; set; }
    }
}
