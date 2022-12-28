using DomainLayer.Models;
using ServiceLayer.Services;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Practices.Controllers
{
    internal class CustomerController
    {
        private readonly ICustomerService _service;

        public CustomerController()
        {
            _service = new CustomerService();
        }

        public void GetCustomerByFiltired()
        {
            Console.WriteLine(_service.GetCustomerByFiltired());
        }

        public void GetCustomersAvarageByAges()
        {
            Console.WriteLine(_service.GetCustomersAvarageByAges());
        }
    }
}
