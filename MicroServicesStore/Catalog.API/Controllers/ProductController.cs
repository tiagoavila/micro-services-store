using System;
using System.Net;
using Catalog.Application.Dtos;
using Catalog.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productAppService.GetAll());
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_productAppService.GetById(id));
        }

        [HttpPut("update")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult UpdateProduct([FromBody]ProductDto productDto)
        {
            var result = _productAppService.Update(productDto);
            if (result.Success)
            {
                return NoContent();
            }

            return BadRequest(result.Message);
        }
    }
}