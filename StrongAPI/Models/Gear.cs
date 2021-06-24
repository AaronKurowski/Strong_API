using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StrongAPI.Models
{
    public class Gear
    {
        public int GearId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ImageURL { get; set; }
        public string Condition { get; set; }
        public DateTime DateListed { get; set; }
    }
}
