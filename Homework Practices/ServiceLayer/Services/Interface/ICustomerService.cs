﻿using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interface
{
    public interface ICustomerService
    {
        int GetCustomerByFiltired();
        double GetCustomersAvarageByAges();
    }
}
