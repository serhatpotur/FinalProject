using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());
            // new InMemoryProductDal verilerin hangi data türünden? geleceğini söyleriz (EF,CodeFirst,MySql,Postgre)  






            //GetAllCategory();
           // GetProductDetails();
            //GetByUnitPrice();
            //GetAllProduct();
            //GetAllByCategoryId();
        }

        private static void GetProductDetails()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName + " - " + item.CategoryName);
            }
        }

        private static void GetAllCategory()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryId + " - " + item.CategoryName);
            }
        }

        private static void GetAllProduct()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductId + " - " + item.ProductName);
            }
        }

        private static void GetAllByCategoryId()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(item.ProductId + " - " + item.ProductName + " - " + item.CategoryId);
            }
        }

        private static void GetByUnitPrice()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetByUnitPrice(10, 20))
            {
                Console.WriteLine(item.ProductId + " - " + item.ProductName + " - " + item.UnitPrice);
            }
        }
    }
}
