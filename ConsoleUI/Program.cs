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
           //GetProductDetails();
            //GetByUnitPrice();
            GetAllProduct();
            //GetAllByCategoryId();
        }

        private static void GetProductDetails()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + " - " + item.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
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
            var result = productManager.GetAll();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductId + " - " + item.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void GetAllByCategoryId()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetAllByCategoryId(2);
            foreach (var item in result.Data)
                if (result.Success)
                {
                    Console.WriteLine(item.ProductId + " - " + item.ProductName + " - " + item.CategoryId);
                }
                else
                {
                    Console.WriteLine(result.Message);
                }
        }

        private static void GetByUnitPrice()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetByUnitPrice(10, 20);
            foreach (var item in result.Data)
            {
                if (result.Success)
                {
                    Console.WriteLine(item.ProductId + " - " + item.ProductName + " - " + item.UnitPrice);

                }
                else
                {
                    Console.WriteLine(result.Message);
                }
            }
        }
    }
}
