using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StudentControlWebApp.Data;
using Entities = StudentControlWebApp.Entities;
using Models = StudentControlWebApp.Models;

namespace StudentControlWebApp.Assemblers.EntityAssembler
{
    public class EntityAssembler()
    {
               
        public Entities.Belt CreateBelt(Models.Belt belt)
        {
            Entities.Belt beltEntity = new Entities.Belt
            {
                BeltId = belt.Id,
                BeltDescription = belt.Description
            };

            return beltEntity;
        }

        public Entities.Person CreatePerson(Models.Person person)
        {
            Entities.Person personEntity = new Entities.Person
            {
                IndividualId = 0, //autonumérico
                DocumentNumber = person.DocumentNumber,
                FirstName = person.FirstName,
                MiddleName = person.MiddleName,
                LastName = person.LastName,
                SecondLastName = person.SecondLastName,
                BirthDate = person.BirthDate,
                Address = person.Address,
                PhoneNumber = person.PhoneNumber,
                CellphoneNumber = person.CellphoneNumber,
                MailAddress = person.MailAddress
            };

            return personEntity;
        }
        
    }
}