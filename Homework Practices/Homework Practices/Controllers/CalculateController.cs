using ServiceLayer.Services;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Practices.Controllers
{
    public class CalculateController
    {
        private readonly ICalculateService _service;
        public CalculateController()
        {
            _service = new CalculateService();
        }
        public void MultiplyArrayItems() => Console.WriteLine(_service.MultiplyArrayItems(GetArr()));
        public void SuqareOfSumArrayItems() => Console.WriteLine(_service.SuqareOfSumArrayItems(GetArr()));
        private int[] GetArr() => new[] { 1, 2, 3, 4, 5, 6, 12 };
    }
}