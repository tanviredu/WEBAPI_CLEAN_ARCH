using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandApp.Data.DTO
{
    public class BrandUpdateDTO
    {
        public string BrandName { get; set; }
        public string BrandDescription { get; set; }
        public int CreatorId { get; set; }
    }
}
