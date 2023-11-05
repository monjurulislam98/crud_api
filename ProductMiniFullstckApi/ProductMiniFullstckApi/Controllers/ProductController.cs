using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ProductMiniFullstckApi.Models.Domain;
using ProductMiniFullstckApi.Models.DTOs;
using ProductMiniFullstckApi.Repositories.Abstract;

namespace ProductMiniFullstckApi.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepos;
        public ProductController(IProductRepository productRepo)
        {
            _productRepos = productRepo;
        }
        [HttpGet]
        public IActionResult GetAll(string term="")
        {
            var data = _productRepos.GetAll(term);
            return Ok(data);

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var data = _productRepos.GetById(id);
            return Ok(data);

        }
        [HttpPost]
        public IActionResult AddUpdate(Product model)
        {
            var status = new Status();
            if(!ModelState.IsValid)
            {
                status.StatusCode = 0;
                status.Message = "Validation failed";
            }
            var result = _productRepos.AddUpdate(model);

               status.StatusCode = result ? 1 : 0;
               status.Message = result ? "Saved Successfully" : "Error has occured";
            
            return Ok(status);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _productRepos.Delete(id);
            var status = new Status
            {
                StatusCode = result ? 1 : 0,
                Message = result ? "Deletd Successfully" : "Error has occured"
            };
               return Ok(status);

        }
    }
}
