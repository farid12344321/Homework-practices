using DomainLayer.Models;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerService
    {
        public int GetCustomerByFiltired()
        {
            var costumers = GetAll();
            int count = 0;
            foreach (var item in costumers)
            {
                if (item.Age >25 && item.Age <30)
                {
                    count++;
                }
            }
            return count;
        }
        public double GetCustomersAvarageByAges()
        {
            var costumers = GetAll();
            double sumAge = 0;

            foreach (var item in costumers)
            {
                sumAge+= item.Age;
            }
            return Math.Ceiling(sumAge / costumers.Length);
        }

        private Customer[] GetAll()
        {
            Customer c1 = new Customer()
            {
                Id = 1,
                Name = "Shaiq",
                Surname="Kazimov",
                Age= 25,
                Position="Backend Develpor"
                
            };

            Customer c2 = new Customer()
            {
                Id = 2,
                Name = "Pervin",
                Surname = "Rehimli",
                Age = 25,
                Position = "Frontend Develpor"

            };

            Customer c3 = new Customer()
            {
                Id = 3,
                Name = "Aqsin",
                Surname = "Hummetov",
                Age = 27,
                Position = "FullStack Develpor"

            };

            Customer c4 = new Customer()
            {
                Id = 4,
                Name = "Jale",
                Surname = "Abdullayev",
                Age = 18,
                Position = "Software Instuctor "

            };
            Customer[] customers = { c1, c2, c3, c4 };
            return customers;
        }
    }
}