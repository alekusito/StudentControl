using Microsoft.AspNetCore.Mvc;
using StudentControlWebApp.Data;
using Models = StudentControlWebApp.Models;
using Entities = StudentControlWebApp.Entities;
using StudentControlWebApp.Assemblers;
using StudentControlWebApp.Assemblers.ModelAssembler;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StudentControlWebApp.Assemblers.EntityAssembler;

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
        private readonly EntityAssembler _entityAssembler = new EntityAssembler();

        #endregion Controllers

        public IActionResult Person()
        {
            return View();
        }

        [HttpPost("Person/GetPersons")]
        public JsonResult GetPersons()
        {
            List<Models.ViewModels.PersonModel> personModels = new List<Models.ViewModels.PersonModel>();
            List<Entities.Person> personEntities = _appDbContext.Persons.ToList();
            List<Models.Person> persons = _modelAssembler.CreatePersons(personEntities);

            if (persons.Count > 0)
            {
                foreach(var item in persons)
                {
                    Models.ViewModels.PersonModel personModel = new Models.ViewModels.PersonModel();
                    personModel.IndividualId = item.IndividualId;
                    personModel.DocumentNumber = item.DocumentNumber;
                    personModel.FirstName = item.FirstName;
                    personModel.MiddleName = item.MiddleName;
                    personModel.LastName = item.LastName;
                    personModel.SecondLastName = item.SecondLastName;
                    personModel.FormatedBirthDate = String.Format("{0:dd/MM/yyyy}",item.BirthDate);
                    personModel.Age = item.BirthDate.Date.Month > DateTime.Today.Month ? DateTime.Today.Year - item.BirthDate.Date.Year - 1 : DateTime.Today.Year - item.BirthDate.Date.Year;

                    personModels.Add(personModel);
                }
            }

            return Json(personModels);
        }

        [HttpPost("Person/SavePerson")]
        public JsonResult SavePerson(Models.Person person)
        {
            Entities.Person personEntity = _entityAssembler.CreatePerson(person);
            _appDbContext.Persons.Add(personEntity);
            _appDbContext.SaveChanges();

            int id = personEntity.IndividualId;

            return Json(id);
        }

        [HttpPost("Person/UpdatePerson")]
        public JsonResult UpdatePerson(Models.Person person)
        {
            Entities.Person personEntity = _entityAssembler.CreatePerson(person);
            _appDbContext.Persons.Update(personEntity);
            _appDbContext.SaveChanges();

            return Json(person);
        }

        [HttpPost("Person/DeletePerson")]
        public void UpdatePerson(int individualId)
        {
            Entities.Person personEntity = _appDbContext.Persons.FirstOrDefault(x => x.IndividualId == individualId);

            if (personEntity != null)
            {
                _appDbContext.Remove(personEntity);
                _appDbContext.SaveChanges();
            }
        }

        [HttpPost("Person/GetPerson")]
        public JsonResult GetPerson(int individualId)
        {
            Entities.Person personEntity = _appDbContext.Persons.FirstOrDefault(x => x.IndividualId == individualId);

            return Json(_modelAssembler.CreatePerson(personEntity));
        }
    }
}