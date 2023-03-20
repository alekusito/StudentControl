using System;
using System.Collections.Generic;
using StudentControl.DAL;
using StudentControl.ParametrizationServices.DAOs;

namespace StudentControl.ParametrizationServices
{
	public class ParametrizationServiceProvider : IParametrizationService
    {
        #region Context

        public StudentControlContext _studentControlContext;

        public ParametrizationServiceProvider(StudentControlContext studentControlContext)
        {
            _studentControlContext = studentControlContext;
        }

        #endregion Context

        #region DAO

        public BeltDAO _beltDAO = new BeltDAO();

        #endregion DAO

        #region Belt

        /// <summary>
        /// GetBelts
        /// </summary>
        /// <returns></returns>
        public List<Models.Belt> GetBelts()
        {
            List<Models.Belt> belts = _beltDAO.GetBelts(_studentControlContext);
            return belts;
        }

        #endregion Belt
    }
}

