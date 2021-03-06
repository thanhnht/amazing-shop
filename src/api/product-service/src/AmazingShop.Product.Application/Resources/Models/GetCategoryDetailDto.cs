using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AmazingShop.Product.Application.Product.Dto;

namespace AmazingShop.Product.Application.Resource.Dto
{
    public class GetCategoryDetailDto : BaseDto<int>
    {
        public IEnumerable<ProductDetailDto> Products { get; set; }
        public static Expression<Func<Domain.Entity.Category, GetCategoryDetailDto>> Projection
        {
            get
            {
                return model => new GetCategoryDetailDto
                {
                    Id = model.Id,
                    Name = model.Name,
                    Products = model.Products.Select(ProductDetailDto.Create)
                };
            }
        }

        public static GetCategoryDetailDto Create(Domain.Entity.Category entity)
        {
            if (entity == null)
            {
                return null;
            }
            return Projection.Compile().Invoke(entity);
        }
    }
}