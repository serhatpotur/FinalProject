using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    // IDataResult dememizin sebebi generic olması , success ve message kontrollerini yapabilmemiz
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();   // T : <List<Product>
        IDataResult<List<Product>> GetAllByCategoryId(int Id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);
        IDataResult<Product> GetById(int productId); // T : <Product>
    }
}
