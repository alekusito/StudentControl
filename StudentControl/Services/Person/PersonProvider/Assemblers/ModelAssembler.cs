using Models = StudentControl.PersonServices.Models;
using Entities = StudentControl.PersonServices.Entities;

namespace StudentControl.PersonServices.Provider.Assemblers
{
    public class ModelAssembler
    {
        public static Models.Person CreatePerson(Entities.Person personEntity)
        {
            Models.Person person = new Models.Person();
            person.IndividualId = personEntity.IndividualId;
            person.DocumentNumber = personEntity.DocumentNumber;
            person.FirstName = personEntity.FirstName;
            person.MiddleName = personEntity.MiddleName;
            person.LastName = personEntity.LastName;
            person.SecondLastName = personEntity.SecondLastName;
            person.PhoneNumber = personEntity.PhoneNumber;
            person.CellPhoneNumber = personEntity.CellPhoneNumber;
            person.MailAddress = personEntity.MailAddress;

            return person;
        }
        
    }
}
