using BrandApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandApp.Data.Service
{
    public interface IBrand
    {
        List<Brand> GetAllBrands();
        Brand GetBrandById(int id);
        List<Brand> AddBrand(Brand brand);
        void updateBrand();
        List<Brand>DeleteBrand(int id);
        void SaveChanges();
    }
}
