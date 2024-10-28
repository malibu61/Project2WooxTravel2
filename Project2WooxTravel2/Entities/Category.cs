using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Project2WooxTravel2.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        [StringLength(100)]
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        //public ICollection<Destination> Destinations { get; set; }

    }
}