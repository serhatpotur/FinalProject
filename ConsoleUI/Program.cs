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

            // sadece alt yapımı InMemoryden EF'ye değiştirdim . Geri kalan sistemler aynı




            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetByUnitPrice(10,20))
            {
                Console.WriteLine(item.ProductId + " - " + item.ProductName + " - " + item.UnitPrice);
            }
            //foreach (var item in productManager.GetAll())
            //{
            //    Console.WriteLine(item.ProductId + " - " + item.ProductName);
            //}

            //foreach (var item in productManager.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine(item.ProductId + " - " + item.ProductName + " - " + item.CategoryId);
            //}
        }
    }
}
