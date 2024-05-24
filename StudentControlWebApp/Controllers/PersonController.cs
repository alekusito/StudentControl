using Microsoft.AspNetCore.Mvc;
using StudentControlWebApp.Data;
using Models = StudentControlWebApp.Models;
using Entities = StudentControlWebApp.Entities;
using StudentControlWebApp.Assemblers;
using StudentControlWebApp.Assemblers.ModelAssembler;

namespace SampleMVCApps.Controllers
{    
    public class PersonController : Controller
    {
        #region Context

        private readonly ApplicationDbContext _appDbContext;        

        public PersonController(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        #endregion Context

        #region Controllers

        private readonly ModelAssembler _modelAssembler = new ModelAssembler();

        #endregion Controllers

        public IActionResult Person()
        {            
            return View();
        }

        public List<Models.Belt> GetBelts()
        {            
            List<Entities.Belt> beltEntities = _appDbContext.Belts.ToList();
            return _modelAssembler.CreateBelts(beltEntities);
        }    
    }
}