using System;
using Models = StudentControl.PersonServices.Models;
using Entities = StudentControl.PersonServices.Entities;

namespace StudentControl.PersonServices.Provider.Assemblers
{
    public class EntityAssembler
    {
        public static Entities.Person CreatePerson(Models.Person person)
        {
            Entities.Person personEntity = new Entities.Person();
            personEntity.IndividualId = person.IndividualId;
            personEntity.DocumentNumber = person.DocumentNumber;
            personEntity.FirstName = person.FirstName;
            personEntity.MiddleName = person.MiddleName;
            personEntity.LastName = person.LastName;
            personEntity.SecondLastName = person.SecondLastName;
            personEntity.PhoneNumber = person.PhoneNumber;
            personEntity.CellPhoneNumber = person.CellPhoneNumber;
            personEntity.MailAddress = person.MailAddress;

            return personEntity;
        }
    }
}
