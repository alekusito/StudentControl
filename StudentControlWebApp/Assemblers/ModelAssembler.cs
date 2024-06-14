using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StudentControlWebApp.Data;
using Entities = StudentControlWebApp.Entities;
using Models = StudentControlWebApp.Models;

namespace StudentControlWebApp.Assemblers.ModelAssembler
{
    public class ModelAssembler()
    {

        #region Belt

        public Models.Belt CreateBelt(Entities.Belt beltEntity)
        {
            Models.Belt belt = new Models.Belt
            {
                Id = beltEntity.BeltId,
                Description = beltEntity.BeltDescription
            };

            return belt;
        }

        public List<Models.Belt> CreateBelts(List<Entities.Belt> beltEntities)
        {
            List<Models.Belt> belts = new List<Models.Belt>();

            foreach (Entities.Belt beltEntity in beltEntities)
            {
                belts.Add(CreateBelt(beltEntity));
            }

            return belts;
        }

        #endregion Belt

        #region Person

        public Models.Person CreatePerson(Entities.Person personEntity)
        {
            Models.Person person = new Models.Person
            {
                IndividualId = personEntity.IndividualId,
                DocumentNumber = personEntity.DocumentNumber,
                FirstName = personEntity.FirstName,
                MiddleName = personEntity.MiddleName,
                LastName = personEntity.LastName,
                SecondLastName = personEntity.SecondLastName,
                BirthDate = personEntity.BirthDate,
                Address = personEntity.Address,
                PhoneNumber = personEntity.PhoneNumber,
                CellphoneNumber = personEntity.CellphoneNumber,
                MailAddress = personEntity.MailAddress
            };

            return person;
        }

        public List<Models.Person> CreatePersons(List<Entities.Person> personEntities)
        {
            List<Models.Person> persons = new List<Models.Person>();

            foreach (Entities.Person personEntity in personEntities)
            {
                persons.Add(CreatePerson(personEntity));
            }

            return persons;
        }

        #endregion Person
    }
}