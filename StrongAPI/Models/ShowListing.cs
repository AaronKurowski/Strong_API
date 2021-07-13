using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StrongAPI.Models
{
    public class ShowListing
    {
        public int ShowListingId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Bands { get; set; }
        public int EntryFee { get; set; }
        public string ImageURL { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
    }
}
