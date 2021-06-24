using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StrongAPI.Models
{
    public class GearBag
    {
        [Key, Column(Order = 0)]
        public int GearId { get; set; }

        [Key, Column(Order = 1)]
        public string UserId { get; set; }

        [ForeignKey("GearId")]
        public virtual Gear Gear { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int Quantity { get; set; }

    }
}
