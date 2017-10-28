using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GalaxyHiking.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public string Galaxy { get; set; }
        public string Planet { get; set; }
        public string PlanetType { get; set; }
        public int AlienEncounters { get; set; }
        public bool IsFriendly { get; set; }
        public string Comments { get; set; }
        public DateTime PostDate { get; set; }
        public string Author { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}