using Catalog.Application.Dtos;
using Catalog.Application.Interfaces;
using Catalog.Domain.Interfaces;
using Omu.ValueInjecter;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.Application.Services
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductRepository _productRepository;

        public ProductAppService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<ProductDto> GetAll()
        {
            return _productRepository.GetAll().Select(x => new ProductDto().InjectFrom(x)).Cast<ProductDto>();
        }

        public ProductDto GetById(Guid id)
        {
            ProductDto productDto = null;

            var product = _productRepository.GetById(id);
            if (product != null)
            {
                productDto = Mapper.Map<ProductDto>(product);
            }

            return productDto;
        }
    }
}
