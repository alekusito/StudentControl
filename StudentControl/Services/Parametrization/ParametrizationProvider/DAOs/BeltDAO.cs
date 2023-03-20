using System;
using Models = StudentControl.PersonServices.Models;
using Entities = StudentControl.PersonServices.Entities;
using System.Collections.Generic;
using StudentControl.DAL;
using StudentControl.ParametrizationServices.Assemblers;

namespace StudentControl.ParametrizationServices.DAOs
{
	public class BeltDAO
	{
        /// <summary>
        /// GetBelts
        /// </summary>
        /// <param name="_studentControlContext"></param>
        /// <returns></returns>
        public List<Models.Belt> GetBelts(StudentControlContext _studentControlContext)
        {
            return ModelAssembler.CreateBelts(_studentControlContext);
        }
    }
}

