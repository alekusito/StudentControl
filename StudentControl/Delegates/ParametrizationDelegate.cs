using System;
using System.Collections.Generic;
using StudentControl.DAL;
using StudentControl.ParametrizationServices;
using StudentControl.ParametrizationServices.Models;

namespace StudentControl.Delegates
{
    public class ParametrizationDelegate : IParametrizationService
    {
        public ParametrizationServiceProvider _parametrizationServices = new ParametrizationServiceProvider();

        public List<Belt> GetBelts()
        {
            return _parametrizationServices.GetBelts();
        }
    }
}

