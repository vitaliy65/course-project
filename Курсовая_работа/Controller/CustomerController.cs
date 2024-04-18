using System;
using System.Collections.Generic;
using System.Linq;
using Курсовая_работа.Data;
using Курсовая_работа.Interfaces;
using Курсовая_работа.model;

namespace Курсовая_работа.Controller
{
    public class CustomerController : IEntityController<Customer>
    {
        private readonly Le_PeTa_context context;

        public CustomerController()
        {
            context = new Le_PeTa_context();
        }

        public IEnumerable<Customer> GetElements()
        {
            return context.customers;
        }

        public void Add(Customer customer)
        {
            context.customers.Add(customer);
            context.SaveChanges();
        }

        public void RemoveById(int id)
        {
            var customer = context.customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                context.customers.Remove(customer);
                context.SaveChanges();
            }
        }

        public void Remove(Func<Customer, bool> predicate)
        {
            var customers = context.customers.Where(predicate).ToList();
            foreach (var customer in customers)
            {
                context.customers.Remove(customer);
                context.SaveChanges();
            }
        }

        public bool TryFind(Func<Customer, bool> predicate)
        {
            return context.customers.Any(predicate);
        }

        public Customer? Find(Customer customer)
        {
            return context.customers.Where(cs => cs.Id == customer.Id).FirstOrDefault();
        }

        public void Change(Customer customer)
        {
            try
            {
                var existingCustomer = context.customers.SingleOrDefault(c => c.Id == customer.Id);
                if (existingCustomer == null)
                {
                    throw new ArgumentException("Customer not found.");
                }

                context.Entry(existingCustomer).CurrentValues.SetValues(customer);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Customer? FindById(int id)
        {
            return context.customers.Where(cs => cs.Id == id).FirstOrDefault();
        }

        public Customer? Find(Func<Customer, bool> Delegate)
        {
            return context.customers.Where(Delegate).FirstOrDefault();
        }
    }
}
