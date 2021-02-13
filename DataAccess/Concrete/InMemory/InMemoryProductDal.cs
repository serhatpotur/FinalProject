using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    // data access verilerin bilgilerinin tutulduğu katmandır
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=50},
                new Product{ProductId=2,CategoryId=1,ProductName="Tabak",UnitPrice=20,UnitsInStock=5},
                new Product{ProductId=3,CategoryId=2,ProductName="Kamera",UnitPrice=15000,UnitsInStock=10},
                new Product{ProductId=4,CategoryId=2,ProductName="Telefon",UnitPrice=5000,UnitsInStock=150}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
            //Console.WriteLine(product + " " + "adlı ürün eklendi.");
        }

        public void Delete(Product product)
        {
            //Console.WriteLine(product + " " + "adlı ürün silindi.");
            Product ProductToDelete = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            _products.Remove(ProductToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int CategoryId)
        {
            return _products.Where(x => x.CategoryId == CategoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product ProductToUpdate = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            ProductToUpdate.ProductName = product.ProductName;
            ProductToUpdate.ProductId = product.ProductId;
            ProductToUpdate.CategoryId = product.CategoryId;
            ProductToUpdate.UnitPrice = product.UnitPrice;
            ProductToUpdate.UnitsInStock = product.UnitsInStock;




        }
    }
}
