using BrandApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandApp.Data.Service
{
    public class SQLBrand : IBrand
    {
        public CMSContext _context;
        public SQLBrand(CMSContext context)
        {
            _context = context;
        }

        public List<Brand> AddBrand(Brand brand)
        {
            if (brand == null)
            {
                throw new ArgumentNullException(nameof(brand));
            }
            _context.Brands.Add(brand);
            _context.SaveChanges();
            return _context.Brands.ToList();
            
        }

        public List<Brand> DeleteBrand(int id)
        {
            var Itemremoved = GetBrandById(id);
            _context.Brands.Remove(Itemremoved);
            _context.SaveChanges();
            return _context.Brands.ToList();
        }

        public List<Brand> GetAllBrands()
        {
            return _context.Brands.ToList();
        }

        public Brand GetBrandById(int id)
        {
            return _context.Brands.FirstOrDefault(p => p.BrandId == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void updateBrand()
        {
            // nothing
            // all work is in the controller
        }
    }
}
