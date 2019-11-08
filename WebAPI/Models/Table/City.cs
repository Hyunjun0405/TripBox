using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class City
    {
        public City()
        {
            Spot = new HashSet<Spot>();
        }

        public long id { get; set; }
        [StringLength(100)]
        public string continent { get; set; }
        [StringLength(100)]
        public string country { get; set; }
        [StringLength(100)]
        public string state { get; set; }
        [StringLength(100)]
        public string name { get; set; }
        [StringLength(100)]
        public string nameEN { get; set; }

        [InverseProperty("idCityNavigation")]
        public virtual ICollection<Spot> Spot { get; set; }
    }
}