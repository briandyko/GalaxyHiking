using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GalaxyHiking.Models
{
    public class Category
    {
        //Category Fields

        [Key]
        public int CategoryID { get; set; }
        [Display (Name = "Official Galaxy Hike Rating")]
        public string Rating { get; set; }

        //Connection to Review Model

        public virtual ICollection<Review> Reviews { get; set; }

    }
}