using System.Collections.Generic;

namespace BlizzardPinCollector.API.Models
{
    public class Pin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Franchise { get; set; }
        public string Source { get; set; }
        public int Year { get; set; }
        public List<Variant> Variant { get; set; }
        public string Description { get; set; }
    }
}
