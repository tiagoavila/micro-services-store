﻿using System;
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

        // GET: api/Product
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
    }
}