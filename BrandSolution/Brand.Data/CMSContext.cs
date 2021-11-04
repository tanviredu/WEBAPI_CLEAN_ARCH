using Microsoft.EntityFrameworkCore;
using BrandApp.Domain;
using System;

namespace BrandApp.Data
{
    public class CMSContext:DbContext
    {
        public CMSContext(DbContextOptions<CMSContext>opt):base(opt)
        {

        }
        public DbSet<Brand> Brands { get; set; }
    }
}
