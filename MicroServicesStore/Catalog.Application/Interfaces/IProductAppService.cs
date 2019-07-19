using Catalog.Application.Common;
using Catalog.Application.Dtos;
using System;
using System.Collections.Generic;

namespace Catalog.Application.Interfaces
{
    public interface IProductAppService
    {
        IEnumerable<ProductDto> GetAll();

        ProductDto GetById(Guid id);

        Result Update(ProductDto productDto);
    }
}
