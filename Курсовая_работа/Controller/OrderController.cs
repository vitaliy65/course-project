using System;
using System.Collections.Generic;
using System.Linq;
using Курсовая_работа.Data;
using Курсовая_работа.Interfaces;
using Курсовая_работа.model;

namespace Курсовая_работа.Controller
{
    public class OrderController : IEntityController<Order>
    {
        private readonly Le_PeTa_context context;

        public OrderController()
        {
            context = new Le_PeTa_context();
        }

        public IEnumerable<Order> GetElements()
        {
            return context.orders;
        }

        public void Add(Order entity)
        {
            context.orders.Add(entity);
            context.SaveChanges();
        }

        public void RemoveById(int id)
        {
            var order = context.orders.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                context.orders.Remove(order);
                context.SaveChanges();
            }
        }

        public void Remove(Func<Order, bool> predicate)
        {
            var orders = context.orders.Where(predicate).ToList();
            foreach (var order in orders)
            {
                context.orders.Remove(order);
            }
            context.SaveChanges();
        }

        public bool TryFind(Func<Order, bool> predicate)
        {
            return context.orders.Any(predicate);
        }

        public Order? Find(Order entity)
        {
            return context.orders.Where(e => e.Id == entity.Id).FirstOrDefault();
        }

        public void Change(Order order)
        {
            try
            {
                var existingOrder = context.orders.SingleOrDefault(o => o.Id == order.Id);
                if (existingOrder == null)
                {
                    throw new ArgumentException("Order not found.");
                }

                context.Entry(existingOrder).CurrentValues.SetValues(order);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Order? FindById(int id)
        {
            return context.orders.Where(e => e.Id == id).FirstOrDefault();
        }

        public Order? Find(Func<Order, bool> Delegate)
        {
            return context.orders.Where(Delegate).FirstOrDefault();
        }
    }
}
