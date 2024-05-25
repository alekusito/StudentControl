using Microsoft.AspNetCore.Mvc;
using StudentControlWebApp.Data;
using Models = StudentControlWebApp.Models;
using Entities = StudentControlWebApp.Entities;
using StudentControlWebApp.Assemblers;
using StudentControlWebApp.Assemblers.ModelAssembler;

namespace SampleMVCApps.Controllers
{
    public class BeltController : Controller
    {
        #region Context

        private readonly ApplicationDbContext _appDbContext;

        public BeltController(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        #endregion Context

        #region Controllers

        private readonly ModelAssembler _modelAssembler = new ModelAssembler();

        #endregion Controllers

        public IActionResult Belt()
        {
            return View();
        }

        [HttpPost("Belt/GetBelts")]
        public JsonResult GetBelts()
        {
            List<Entities.Belt> beltEntities = _appDbContext.Belts.ToList();
            return Json(_modelAssembler.CreateBelts(beltEntities));
        }
    }
}