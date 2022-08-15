using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        // Burada sadece ürüne ait özel operasyonlar konulur.Ör: ürün detayı için join işlemleri ile birkaç tablodan bilgiyi bir ürün için getircez
        List<ProductDetailDto> GetProductDetails();
    }
}
