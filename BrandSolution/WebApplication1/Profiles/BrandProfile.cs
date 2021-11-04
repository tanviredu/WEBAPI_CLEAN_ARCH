using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrandApp.Data.DTO;
using BrandApp.Domain;

namespace BrandApp.api.Profiles
{
    public class BrandProfile:Profile
    {
        public BrandProfile()
        {
            CreateMap<Brand, BrandReadDTO>();
            CreateMap<BrandCreateDTO, Brand>();
            CreateMap<BrandUpdateDTO, Brand>();
        }
    }
}
