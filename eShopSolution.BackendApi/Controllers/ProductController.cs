using eShopSolution.Application.Catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class ProductController : ControllerBase
    {
        //khoi tao 1 lan thi de gach duoi _pub...
        private readonly IPublicProductService _publicProductService;
        public ProductController(IPublicProductService publicProductService)
        {
            _publicProductService = publicProductService;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var products = await _publicProductService.GetAll();
            return Ok(products);
        }
    }
}
