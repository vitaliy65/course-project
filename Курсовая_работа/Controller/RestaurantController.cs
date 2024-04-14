using System;
using System.Linq;
using Курсовая_работа.Data;
using Курсовая_работа.Interfaces;
using Курсовая_работа.model;

namespace Курсовая_работа.Controller
{
    public class RestaurantController : IEntityController<Restaurant>
    {
        private Le_PeTa_context context;

        public RestaurantController() { context = new Le_PeTa_context(); }

        public IEnumerable<Restaurant> GetElements()
        {
            return context.restaurants;
        }

        public void Add(Restaurant restaurant)
        {
            context.restaurants.Add(restaurant);
            context.SaveChanges();
        }

        public void RemoveById(int id)
        {
            var restaurant = context.restaurants.SingleOrDefault(r => r.Id == id);
            if (restaurant != null)
            {
                context.restaurants.Remove(restaurant);
                context.SaveChanges();
            }
        }

        public void Remove(Func<Restaurant, bool> predicate)
        {
            var foundRestaurant = context.restaurants.FirstOrDefault(predicate);
            if (foundRestaurant != null)
            {
                context.restaurants.Remove(foundRestaurant);
                context.SaveChanges();
            }
        }

        public bool TryFind(Func<Restaurant, bool> predicate)
        {
            return context.restaurants.Any(predicate);
        }

        public Restaurant? Find(Restaurant entity)
        {
            return context.restaurants.Where(e => e.Id == entity.Id).FirstOrDefault();
        }

        public Restaurant? Product(Restaurant entity)
        {
            return context.restaurants.Where(e => e.Id == entity.Id).FirstOrDefault();
        }

        public void Change(Restaurant restaurant)
        {
            try
            {
                var existingRestaurant = context.restaurants.SingleOrDefault(p => p.Id == restaurant.Id);

                if (existingRestaurant == null)
                {
                    throw new ArgumentException("Restaurant not found.");
                }

                // Attach the product to the context and mark it as modified
                context.Entry(existingRestaurant).CurrentValues.SetValues(restaurant);

                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Restaurant? FindById(int id)
        {
            return context.restaurants.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
