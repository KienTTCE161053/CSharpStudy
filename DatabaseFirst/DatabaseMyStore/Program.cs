using System;
using DatabaseMyStore.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DatabaseMyStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStoreContext myStore = new MyStoreContext();

            var products = from p in myStore.Products
                           select new { p.ProductName, p.CategoryId };
            foreach (var p in products) { 
                Console.WriteLine($"CategoryID: {p.ProductName}, CategoryID: {p.CategoryId}");
            }
            IQueryable<Category> cats = myStore.Categories.Include(c => c.Products);
            foreach (Category c in cats)
            {
                Console.WriteLine($"CategoryID: {c.CategoryId} has {c.Products.Count} products.");
            }
            

        }
    }
}
