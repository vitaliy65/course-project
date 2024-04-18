using System;
using System.Collections.Generic;
using System.Linq;
using Курсовая_работа.Data;
using Курсовая_работа.Interfaces;
using Курсовая_работа.model;

namespace Курсовая_работа.Controller
{
    public class ProductController : IEntityController<Product>
    {
        private readonly Le_PeTa_context context;

        public ProductController()
        {
            context = new Le_PeTa_context();
        }

        public IEnumerable<Product> GetElements()
        {
            return context.products;
        }

        public void Add(Product entity)
        {
            context.products.Add(entity);
            context.SaveChanges();
        }

        public bool TryFind(Func<Product, bool> predicate)
        {
            return context.products.Any(predicate);
        }

        public Product? Find(Product entity)
        {
            return context.products.Where(e => e.ProductId == entity.ProductId).FirstOrDefault();
        }

        public Product? Product(Product entity)
        {
            return context.products.Where(e => e.ProductId == entity.ProductId).FirstOrDefault();
        }

        public void RemoveById(int id)
        {
            var product = context.products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                context.products.Remove(product);
                context.SaveChanges();
            }
        }

        public void Remove(Func<Product, bool> predicate)
        {
            var products = context.products.Where(predicate).ToList();
            foreach (var product in products)
            {
                context.products.Remove(product);
            }
            context.SaveChanges();
        }

        public void Change(Product product)
        {
            try
            {
                var existingProduct = context.products.SingleOrDefault(p => p.ProductId == product.ProductId);
                if (existingProduct == null)
                {
                    throw new ArgumentException("Product not found.");
                }

                context.Entry(existingProduct).CurrentValues.SetValues(product);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Product? FindById(int id)
        {
            return context.products.Where(e => e.ProductId == id).FirstOrDefault();
        }

        public Product? Find(Func<Product, bool> Delegate)
        {
            return context.products.Where(Delegate).FirstOrDefault();
        }
    }
}
