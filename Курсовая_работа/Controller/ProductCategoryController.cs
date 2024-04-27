using System;
using System.Linq;
using Курсовая_работа.Data;
using Курсовая_работа.Interfaces;
using Курсовая_работа.model;

namespace Курсовая_работа.Controller
{
    internal class ProductCategoryController : IEntityController<ProductCategory>
    {
        private readonly Le_PeTa_context context;

        public ProductCategoryController()
        {
            context = new Le_PeTa_context();
        }

        public void Add(ProductCategory entity)
        {
            context.productCategories.Add(entity);
            context.SaveChanges();
        }

        public void Change(ProductCategory entity)
        {
            try
            {
                var existingCategory = context.productCategories.SingleOrDefault(p => p.Id == entity.Id);

                context.Entry(existingCategory).CurrentValues.SetValues(entity);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw new ArgumentException("Category not found.");
            }
        }

        public ProductCategory? Find(ProductCategory entity)
        {
            return context.productCategories.Where(e => e.Id == entity.Id).FirstOrDefault();
        }

        public ProductCategory? Find(Func<ProductCategory, bool> Delegate)
        {
            return context.productCategories.Where(Delegate).FirstOrDefault();
        }

        public IEnumerable<ProductCategory>? FindAll(Func<ProductCategory, bool> Delegate)
        {
            return context.productCategories.Where(Delegate);
        }

        public ProductCategory? FindById(int id)
        {
            return context.productCategories.Where(e => e.Id == id).FirstOrDefault();
        }

        public bool TryFind(Func<ProductCategory, bool> Delegate)
        {
            return context.productCategories.Any(Delegate);
        }

        public IEnumerable<ProductCategory> GetElements()
        {
            return context.productCategories;
        }

        public void Remove(Func<ProductCategory, bool> Delegate)
        {
            var categories = context.productCategories.Where(Delegate).ToList();
            if(categories.Count != 0)
            {
                foreach (var category in categories)
                {
                    context.productCategories.Remove(category);
                }
                context.SaveChanges();
            }
        }

        public void RemoveById(int id)
        {
            var category = context.productCategories.FirstOrDefault(p => p.Id == id);
            if (category != null)
            {
                context.productCategories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}