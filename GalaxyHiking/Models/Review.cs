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
        [Display (Name = "Primarily Composted of:")]
        public string PlanetType { get; set; }
        [Display(Name = "How many aliens did you see?")]
        public int AlienEncounters { get; set; }
        [Display(Name = "Please check if the aliens were friendly")]
        public bool IsFriendly { get; set; }
        public string Comments { get; set; }
        public DateTime PostDate { get; set; }
        public string Author { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}