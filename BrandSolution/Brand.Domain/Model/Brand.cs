using System;

namespace BrandApp.Domain
{
    public class Brand
    {
        public int  BrandId { get; set; }
        public string BrandName { get; set; }
        public string  BrandDescription { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
