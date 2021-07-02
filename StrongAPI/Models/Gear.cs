using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
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
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string ImageURL { get; set; }
        public string Condition { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string DateListed { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
    }
}
