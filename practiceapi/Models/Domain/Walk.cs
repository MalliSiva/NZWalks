using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practiceapi.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }
         public Guid DufficultyId { get; set; }
        public Guid RegionId { get; set; }

        //Navigtation properties
        public Difficulty Difficulty{get; set;}
        public Region Region { get; set; }
    }
}