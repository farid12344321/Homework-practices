﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interface
{
    public interface ICalculateService
    {
        int MultiplyArrayItems(int[] arr);
        int SuqareOfSumArrayItems(int[] arr);
    }
}
