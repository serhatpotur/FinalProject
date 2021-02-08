using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    // İş kodları yazılır. yapılan işler burda sorgulanır
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // iş kodları yazılır
            // if else kodları bu katmana yazılır. rol admin mi, ürün bilgileri doğru mu diye vs vs

            return _productDal.GetAll();
        }
    }
}
