using System;
using System.Collections.Generic;

namespace StudentControl.ParametrizationServices
{
	public interface IParametrizationService
	{
        #region Belt

        /// <summary>
        /// GetBelts
        /// </summary>
        /// <returns></returns>
        List<Models.Belt> GetBelts();

        #endregion Belt

    }
}

