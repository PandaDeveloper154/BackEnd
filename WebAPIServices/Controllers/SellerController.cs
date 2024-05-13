using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIServices.Models;
using WebAPIServices.Services.SuperHeroService;

namespace WebAPIServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly ISellerService _sellerService;

        public SellerController(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Seller>>> GetAllSellers()
        {
            
            return _sellerService.GetAllSellers();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Seller>> GetSingleSeller(int id)
        {
            var result = _sellerService.GetSingleSeller(id);
            if (result is null)
                return NotFound("Seller not found");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Seller>>> AddSeller(Seller seller)
        {
            var result = _sellerService.AddSeller(seller);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Seller>>> UpdateSeller(int id,Seller request)
        {
            var result = _sellerService.UpdateSeller(id, request);
            if (result is null)
                return NotFound("Seller not found");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Seller>>> DeleteSeller(int id)
        {
            var result = _sellerService.DeleteSeller(id);
            if(result is null)
                return NotFound("Seller not found");
            return Ok(result);
        }
    }
}
