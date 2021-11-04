using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrandApp.Data;
using BrandApp.Domain;
using BrandApp.Data.Service;
using AutoMapper;
using BrandApp.Data.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/Brands")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrand _brand;
        private readonly IMapper _mapper;

        public BrandsController(IBrand brand,IMapper mapper)
        {
            _brand = brand;
            _mapper = mapper;

        }
        // GET: api/<BrandsController>
        [HttpGet]
        public ActionResult<IEnumerable<BrandReadDTO>> GetAllbrands()
        {
            var brands = _brand.GetAllBrands();
            return Ok(_mapper.Map<IEnumerable<BrandReadDTO>>(brands));
            
            
        }

        // GET api/<BrandsController>/5
        [HttpGet("{id}")]
        public ActionResult<BrandReadDTO>GetBrandsById(int id)
        {
            try
            {
                var branditem = _brand.GetBrandById(id);
                return Ok(_mapper.Map<BrandReadDTO>(branditem));
            }
            catch {
                return NotFound();
            }
            
        }

        // POST api/<BrandsController>
        [HttpPost]
        public ActionResult<List<BrandReadDTO>> Post(BrandCreateDTO brand)
        {
            
            var brandmodel = _mapper.Map<Brand>(brand);
            return Ok(_brand.AddBrand(brandmodel));

        }

        // PUT api/<BrandsController>/5
        [HttpPut("{id}")]
        public ActionResult UpdateBrand(int id, BrandUpdateDTO brandUpdateDTO)
        {
            var brandModelfromRepo = _brand.GetBrandById(id);
            if (brandModelfromRepo == null) {
                return NotFound();
            }

            // little different
            _mapper.Map(brandUpdateDTO, brandModelfromRepo);
            _brand.SaveChanges();
            return NoContent();

        }

        // DELETE api/<BrandsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_brand.DeleteBrand(id));

        }
    }
}
