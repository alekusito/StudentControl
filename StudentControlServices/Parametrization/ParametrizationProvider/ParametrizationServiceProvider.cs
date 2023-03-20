using StudentControl.DAL;
using StudentControl.ParametrizationServices.Assemblers;

namespace StudentControl.ParametrizationServices
{
	public class ParametrizationServiceProvider : IParametrizationService
    {
        #region Context

        private readonly DataBaseContext _dataBaseContext;

        public ParametrizationServiceProvider(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public ParametrizationServiceProvider()
        {
        }

        #endregion Context


        #region Assemblers

        EntityAssembler entityAssembler = new EntityAssembler();
        ModelAssembler modelAssembler = new ModelAssembler();

        #endregion Assemblers


        #region Belt

        /// <summary>
        /// GetBelts
        /// </summary>
        /// <returns></returns>
        public List<Models.Belt> GetBelts()
        {
            List<Models.Belt> belts = modelAssembler.CreateBelts(_dataBaseContext);
            return belts;
        }

        #endregion Belt
    }
}

