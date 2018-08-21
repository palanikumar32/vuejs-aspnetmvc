using System.Collections.Generic;
using System.Linq;

namespace VueJsAspNetMVC.Models
{
    public class Countries
    {
        public int ID { get; set; }
        public string Country { get; set; }

        public List<Countries> Get()
        {
            return Enumerable.Range(1, 50).Select(x => new Countries  { ID = x, Country = "Country " + x.ToString() }).ToList();
        }
    }
}